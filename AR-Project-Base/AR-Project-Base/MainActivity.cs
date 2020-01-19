using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Google.AR.Core;
using System.Collections.Generic;
using Android.Support.V4.Content;
using Android.Opengl;
using Android.Views;
using Android.Support.V4.App;
using System.Collections.Concurrent;
using AR_Project_Base.Rendering;
using Android.Support.Design.Widget;
using System;
using Javax.Microedition.Khronos.Opengles;
using Android.Util;
using System.Text;
using AR_Project_Base.Models;
// using AR_Project_Base.Models

namespace AR_Project_Base
{
    [Activity(Label = "@string/main_app_name", Theme = "@style/CustomARTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, GLSurfaceView.IRenderer, Android.Views.View.IOnTouchListener
    {
        private static int MAX_CUBE_COUNT = 16;
        private static float SCALE_FACTOR = 0.6f;
        private static float DEFAULT_HEIGHT = 0.1f;

        const string TAG = "AR-APP";
        GLSurfaceView mSurfaceView;
        Session mSession;

        BackgroundRenderer mBackgroundRenderer = new BackgroundRenderer();
        GestureDetector mGestureDetector;
        Snackbar mLoadingMessageSnackbar = null;
        Snackbar mContentMessageSnackbar = null;
        Snackbar mTopMessageSnackBar = null;
        DisplayRotationHelper mDisplayRotationHelper;

        ObjectRenderer mVirtualObject = new ObjectRenderer();
        ObjectRenderer mVirtualObjectShadow = new ObjectRenderer();
        PlaneRenderer mPlaneRenderer = new PlaneRenderer();
        PointCloudRenderer mPointCloud = new PointCloudRenderer();

        // Temporary matrix allocated here to reduce number of allocations for each frame.
        static float[] mAnchorMatrix = new float[16];
        Button viewButton;
        ConcurrentQueue<MotionEvent> mQueuedSingleTaps = new ConcurrentQueue<MotionEvent>();

        // Tap handling and UI.
        List<Anchor> mAnchors = new List<Anchor>();
        TextView mTextView;
        TextView mBottomTextView;
        ImageView imageView;
        private int viewWidth = 0;
        private int viewHeight = 0;
        private RectanglePolygonRenderer rectRenderer = null;
        private float[] anchorMatrix = new float[MAX_CUBE_COUNT];

        List<Pose> horizontalPoseArray = new List<Pose>();
        List<Pose> verticalPoseArray = new List<Pose>();
        Pose basePoint0;
        List<float> heightVals1 = new List<float>();
        List<float> heightVals2 = new List<float>();
        public List<BoxModel> boxModelList = new List<BoxModel>();
        public List<string> boxModelStringList = new List<string>();
        float currentLenthValue;
        float currentBreadthValue;
        float currentHeightValue;
        bool isUpdated = false;
        bool isSurfaceLoaded = false;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            // Display image view
            DisplayTopTextView();
            DisplayBottomTextView();
            ShowCompleteButton();

            mSurfaceView = FindViewById<GLSurfaceView>(Resource.Id.surfaceview);
            mDisplayRotationHelper = new DisplayRotationHelper(this);

            Java.Lang.Exception exception = null;
            string message = null;

            mSession = new Session(/*context=*/this);

            if (message != null)
            {
                Toast.MakeText(this, message, ToastLength.Long).Show();
                return;
            }

            // Create default config, check is supported, create session from that config.
            var config = new Google.AR.Core.Config(mSession);
            if (!mSession.IsSupported(config))
            {
                Toast.MakeText(this, "This device does not support AR", ToastLength.Long).Show();
                Finish();
                return;
            }
            mSession.Configure(config);

            mGestureDetector = new Android.Views.GestureDetector(this, new SimpleTapGestureDetector
            {
                SingleTapUpHandler = (MotionEvent arg) =>
                {
                    onSingleTap(arg);
                    return true;
                },
                DownHandler = (MotionEvent arg) => true
            });

            mSurfaceView.SetOnTouchListener(this);

            // Set up renderer.
            mSurfaceView.PreserveEGLContextOnPause = true;
            mSurfaceView.SetEGLContextClientVersion(2);
            mSurfaceView.SetEGLConfigChooser(8, 8, 8, 8, 16, 0); // Alpha used for plane blending.
            mSurfaceView.SetRenderer(this);
            mSurfaceView.RenderMode = Rendermode.Continuously;
            mSurfaceView.SetZOrderMediaOverlay(true);
        }

        private void DisplayTopTextView()
        {
            var message = "Welcome to [Box]ed-AR";
            mTextView = new TextView(this);
            mTextView.SetText(message.ToCharArray(), 0, message.Length);
            mTextView.SetTextColor(Android.Graphics.Color.OrangeRed);
            mTextView.SetTextSize(ComplexUnitType.Sp, 22);
            mTextView.TextAlignment = TextAlignment.Center;
            mTextView.SetBackgroundColor(Android.Graphics.Color.Black);
            mTextView.SetWidth(5000);
            FrameLayout.LayoutParams params1 = new FrameLayout.LayoutParams(RelativeLayout.LayoutParams.WrapContent, RelativeLayout.LayoutParams.WrapContent);
            params1.Gravity = GravityFlags.Top;
            AddContentView(mTextView, params1);
        }

        private void UpdateTopTextView(string message)
        {
            this.RunOnUiThread(() =>
            {
                mTextView.SetText(message.ToCharArray(), 0, message.Length);
                mTextView.SetWidth(5000);
            });
        }

        private void DisplayBottomTextView()
        { 
            var message = "\n\n■■■■■■■■■■■■■■■■■■■■■■■■■■■\n\t\t\tComplete your box for dimensions.\n■■■■■■■■■■■■■■■■■■■■■■■■■■■";
            mBottomTextView = new TextView(this);
            mBottomTextView.SetText(message.ToCharArray(), 0, message.Length);
            mBottomTextView.SetTextColor(Android.Graphics.Color.White);
            mTextView.TextAlignment = TextAlignment.TextStart;
            mBottomTextView.SetTextSize(ComplexUnitType.Sp, 18);
            mBottomTextView.SetBackgroundColor(Android.Graphics.Color.Black);
            mBottomTextView.SetWidth(1500);
            mBottomTextView.SetHeight(460);
            FrameLayout.LayoutParams params1 = new FrameLayout.LayoutParams(RelativeLayout.LayoutParams.WrapContent, RelativeLayout.LayoutParams.WrapContent);
            params1.Gravity = GravityFlags.Bottom;
            AddContentView(mBottomTextView, params1);
        }

        private void UpdateBottomTextView(string message)
        {
            mBottomTextView.SetText(message.ToCharArray(), 0, message.Length);
            mBottomTextView.SetWidth(1500);
            mBottomTextView.SetWidth(460);
        }

        protected override void OnResume()
        {
            base.OnResume();

            // ARCore requires camera permissions to operate. If we did not yet obtain runtime
            // permission on Android M and above, now is a good time to ask the user for it.
            if (ContextCompat.CheckSelfPermission(this, Android.Manifest.Permission.Camera) == Android.Content.PM.Permission.Granted)
            {
                if (mSession != null)
                {
                    // MakeToast("empty toast");
                    // showLoadingMessage();
                    UpdateTopTextView("Searching for surfaces");
                    // ShowHelperImage();
                    // Note that order matters - see the note in onPause(), the reverse applies here.
                    mSession.Resume();
                }

                mSurfaceView.OnResume();
                mDisplayRotationHelper.OnResume();
            }
            else
            {
                ActivityCompat.RequestPermissions(this, new string[] { Android.Manifest.Permission.Camera }, 0);
            }
        }

        private void ShowHelperImage()
        {
            imageView = new ImageView(this);
            imageView.SetImageResource(Resource.Drawable.movePhoneImage);
        }

        private void HideHelperImage()
        {
            imageView = null;
        }

        private void MakeToast(string message)
        {
            Toast toast = Toast.MakeText(this, message, ToastLength.Long);
            toast.SetGravity(GravityFlags.Top | GravityFlags.CenterHorizontal, 0, 0);
            toast.Show();
        }

        protected override void OnPause()
        {
            base.OnPause();
            if (ContextCompat.CheckSelfPermission(this, Android.Manifest.Permission.Camera) == Android.Content.PM.Permission.Granted)
            {
                // Note that the order matters - GLSurfaceView is paused first so that it does not try
                // to query the session. If Session is paused before GLSurfaceView, GLSurfaceView may
                // still call mSession.update() and get a SessionPausedException.
                mDisplayRotationHelper.OnPause();
                mSurfaceView.OnPause();
                if (mSession != null)
                    mSession.Pause();
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Android.Content.PM.Permission[] grantResults)
        {
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            if (ContextCompat.CheckSelfPermission(this, Android.Manifest.Permission.Camera) != Android.Content.PM.Permission.Granted)
            {
                Toast.MakeText(this, "Camera permission is needed to run this application", ToastLength.Long).Show();
                Finish();
            }
        }
        

        public override void OnWindowFocusChanged(bool hasFocus)
        {
            base.OnWindowFocusChanged(hasFocus);

            if (hasFocus)
            {
                // Standard Android full-screen functionality.
                //Window.DecorView.SystemUiVisibility = Android.Views.SystemUiFlags.LayoutStable
                //| Android.Views.SystemUiFlags.LayoutHideNavigation
                //| Android.Views.SystemUiFlags.LayoutFullscreen
                //| Android.Views.SystemUiFlags.HideNavigation
                //| Android.Views.SystemUiFlags.Fullscreen
                //| Android.Views.SystemUiFlags.ImmersiveSticky;

                Window.AddFlags(WindowManagerFlags.KeepScreenOn);
            }
        }
        private void onSingleTap(MotionEvent e)
        {
            // Queue tap if there is space. Tap is lost if queue is full.
            if (mQueuedSingleTaps.Count < 16)
                mQueuedSingleTaps.Enqueue(e);
        }

        public void OnSurfaceCreated(IGL10 gl, Javax.Microedition.Khronos.Egl.EGLConfig config)
        {
            GLES20.GlClearColor(0.1f, 0.1f, 0.1f, 1.0f);

            // Create the texture and pass it to ARCore session to be filled during update().
            mBackgroundRenderer.CreateOnGlThread(/*context=*/this);
            if (mSession != null)
                mSession.SetCameraTextureName(mBackgroundRenderer.TextureId);

            // Prepare the other rendering objects.
            try
            {
                rectRenderer = new RectanglePolygonRenderer();
                mVirtualObject.CreateOnGlThread(/*context=*/this, "cube.obj", "red_texture.png");
                mVirtualObject.setMaterialProperties(0.0f, 1.5f, 1.0f, 4.0f);

                mVirtualObjectShadow.CreateOnGlThread(/*context=*/this,
                        "andy_shadow.obj", "andy_shadow.png");
                mVirtualObjectShadow.SetBlendMode(ObjectRenderer.BlendMode.Shadow);
                mVirtualObjectShadow.setMaterialProperties(1.0f, 0.0f, 0.0f, 1.0f);
            }
            catch (Java.IO.IOException e)
            {
                Log.Error(TAG, "Failed to read obj file");
            }

            try
            {
                mPlaneRenderer.CreateOnGlThread(/*context=*/this, "dark_grey_texture.png");
            }
            catch (Java.IO.IOException e)
            {
                Log.Error(TAG, "Failed to read plane texture");
            }
            mPointCloud.CreateOnGlThread(/*context=*/this);
        }

        public void OnSurfaceChanged(IGL10 gl, int width, int height)
        {
            mDisplayRotationHelper.OnSurfaceChanged(width, height);
            GLES20.GlViewport(0, 0, width, height);
            viewWidth = width;
            viewHeight = height;
        }

        public void OnDrawFrame(IGL10 gl)
        {
            // Clear screen to notify driver it should not load any pixels from previous frame.
            GLES20.GlClear(GLES20.GlColorBufferBit | GLES20.GlDepthBufferBit);

            if (mSession == null)
                return;

            // Notify ARCore session that the view size changed so that the perspective matrix and the video background
            // can be properly adjusted
            mDisplayRotationHelper.UpdateSessionIfNeeded(mSession);

            try
            {
                // Obtain the current frame from ARSession. When the configuration is set to
                // UpdateMode.BLOCKING (it is by default), this will throttle the rendering to the
                // camera framerate.
                Frame frame = mSession.Update();
                Camera camera = frame.Camera;

                // Handle taps. Handling only one tap per frame, as taps are usually low frequency
                // compared to frame rate.
                MotionEvent tap = null;
                mQueuedSingleTaps.TryDequeue(out tap);

                if (tap != null && camera.TrackingState == TrackingState.Tracking)
                {
                    foreach (var hit in frame.HitTest(tap))
                    {
                        var trackable = hit.Trackable;

                        // Check if any plane was hit, and if it was hit inside the plane polygon.
                        if (trackable is Plane && ((Plane)trackable).IsPoseInPolygon(hit.HitPose))
                        {
                            // Cap the number of objects created. This avoids overloading both the
                            // rendering system and ARCore.
                            if (mAnchors.Count >= 16)
                            {
                                mAnchors[0].Detach();
                                mAnchors.RemoveAt(0);
                            }
                            // Adding an Anchor tells ARCore that it should track this position in
                            // space.  This anchor is created on the Plane to place the 3d model
                            // in the correct position relative to both the world and to the plane
                            mAnchors.Add(hit.CreateAnchor());
                            ShowHelp();

                            // Hits are sorted by depth. Consider only closest hit on a plane.
                            break;
                        }
                    }
                }
                // Draw background.
                mBackgroundRenderer.Draw(frame);

                // If not tracking, don't draw 3d objects.
                if (camera.TrackingState == TrackingState.Paused)
                    return;

                // Get projection matrix.
                float[] projmtx = new float[16];
                camera.GetProjectionMatrix(projmtx, 0, 0.1f, 100.0f);

                // Get camera matrix and draw.
                float[] viewmtx = new float[16];
                camera.GetViewMatrix(viewmtx, 0);

                // Compute lighting from average intensity of the image.
                var lightIntensity = frame.LightEstimate.PixelIntensity;

                // Visualize tracked points.
                var pointCloud = frame.AcquirePointCloud();
                mPointCloud.Update(pointCloud);
                mPointCloud.Draw(camera.DisplayOrientedPose, viewmtx, projmtx);

                // App is repsonsible for releasing point cloud resources after using it
                pointCloud.Release();

                var planes = new List<Plane>();
                foreach (var p in mSession.GetAllTrackables(Java.Lang.Class.FromType(typeof(Plane))))
                {
                    var plane = (Plane)p;
                    planes.Add(plane);
                }

                // Check if we detected at least one plane. If so, hide the loading message.
                if(isSurfaceLoaded) //if(mLoadingMessageSnackbar != null)
                {
                    // bool HPlane = false, VPlane = false;
                    foreach (var plane in planes)
                    {
                        if (plane.GetType() == Plane.Type.HorizontalUpwardFacing
                                && plane.TrackingState == TrackingState.Tracking)
                        {
                            // HPlane = true;
                            isSurfaceLoaded = true;
                            // UpdateMessage("");
                            // hideLoadingMessage();
                            // UpdateMessage("");
                            break;
                        }
                        
                    }
                    UpdateTopTextView("");
                    MakeToast("Surface Detected");
                }

                // Visualize planes.
                mPlaneRenderer.DrawPlanes(planes, camera.DisplayOrientedPose, projmtx);
                // UpdateTopMessage();
                // draw cube & line from last frame
                if (mAnchors.Count < 1)
                {
                    // no point
                    // ShowLength("");
                }
                else
                {
                    heightVals1.Clear();
                    heightVals2.Clear();
                    // draw selected cube
                    StringBuilder sb = new StringBuilder();
                    double total = 0;
                    Pose point1;
                    //// draw first cube
                    Pose point0 = getPose(mAnchors[0]);
                    bool isHeightSet = false;
                    // draw the rest cube
                    basePoint0 = point0;
                    for (var i = 0; i < mAnchors.Count; i++)
                    {

                        if (mAnchors.Count % 4 != 0)
                        {
                            point1 = getPose(mAnchors[i]);
                            if ((i + 1) % 4 != 0)
                            {
                                drawObj(point1, mVirtualObject, viewmtx, projmtx, lightIntensity);
                            }
                            
                            // drawLine(point0, point1, viewmtx, projmtx);
                            if(mAnchors.Count % 4 == 2)
                            {
                                currentLenthValue = ((int)(getDistance(point0, point1) * 1000)) / 10.0f;
                            }
                            else if(mAnchors.Count % 4 == 3)
                            {
                                currentBreadthValue = ((int)(getDistance(point0, point1) * 1000)) / 10.0f;

                            }
                            
                            //float distanceCm = ((int)(getDistance(point0, point1) * 1000)) / 10.0f;
                            //total += distanceCm;
                            //sb.Append(" + ").Append(distanceCm);

                            point0 = point1;
                        }
                        else if(mAnchors.Count % 4 == 0) //&& (i+1) % 4 == 0 && i != 0
                        {
                            int m = mAnchors.Count - 1;

                            DEFAULT_HEIGHT = (float)getDistance(getPose(mAnchors[m]), getPose(mAnchors[m-2])) / 2;
                            currentHeightValue = ((int)(DEFAULT_HEIGHT * 1000)) / 10.0f;
                            // DEFAULT_HEIGHT = currentHeightValue;
                            heightVals1.Add(DEFAULT_HEIGHT);
                            heightVals2.Add(currentHeightValue);

                            isHeightSet = true;
                            break;
                        }
                    }

                    // changes - Begin
                    boxModelList.Clear();
                    horizontalPoseArray.Clear();
                    verticalPoseArray.Clear();

                    if (mAnchors.Count > 3)  // length, breadth and height are set
                    {
                        int k = 0;
                        
                        for (var j = 0; (j < mAnchors.Count && mAnchors.Count - j >3); j += 4)
                        {
                            if (k < heightVals1.Count && k < heightVals2.Count)
                            {
                                DEFAULT_HEIGHT = heightVals1[k];
                                currentHeightValue = heightVals2[k];
                                k = k + 1;
                            }

                            Pose p1 = getPose(mAnchors[j+0]);
                            Pose p2 = getPose(mAnchors[j+1]);
                            Pose p3 = getPose(mAnchors[j+2]);
                            horizontalPoseArray.Add(p1);
                            horizontalPoseArray.Add(p2);
                            horizontalPoseArray.Add(p3);
                            Pose p4 = Calculate4thPoint(horizontalPoseArray[j+0], horizontalPoseArray[j+1], horizontalPoseArray[j+2]);
                            horizontalPoseArray.Add(p4);
                            drawObj(p4, mVirtualObject, viewmtx, projmtx, lightIntensity);
                            verticalPoseArray.AddRange(CalculateVerticalPoseArray(horizontalPoseArray[j + 0], horizontalPoseArray[j + 1], horizontalPoseArray[j + 2], horizontalPoseArray[j + 3], DEFAULT_HEIGHT));

                            // Draw full cube on confirm
                            drawLine(verticalPoseArray[j + 0], verticalPoseArray[j + 1], viewmtx, projmtx);
                            drawLine(verticalPoseArray[j + 1], verticalPoseArray[j + 2], viewmtx, projmtx);
                            drawLine(verticalPoseArray[j + 2], verticalPoseArray[j + 3], viewmtx, projmtx);
                            drawLine(verticalPoseArray[j + 3], verticalPoseArray[j + 0], viewmtx, projmtx);

                            drawLine(horizontalPoseArray[j + 0], verticalPoseArray[j + 0], viewmtx, projmtx);
                            drawLine(horizontalPoseArray[j + 1], verticalPoseArray[j + 1], viewmtx, projmtx);
                            drawLine(horizontalPoseArray[j + 2], verticalPoseArray[j + 2], viewmtx, projmtx);
                            drawLine(horizontalPoseArray[j + 3], verticalPoseArray[j + 3], viewmtx, projmtx);

                            boxModelList.Add(new BoxModel()
                            {
                                BoxId = boxModelList.Count + 1,
                                Length = currentLenthValue > currentBreadthValue ? currentLenthValue : currentBreadthValue,
                                Breadth = currentLenthValue > currentBreadthValue ? currentBreadthValue : currentLenthValue,
                                Height = currentHeightValue
                            });

                            

                            isUpdated = true;
                            isHeightSet = false;

                            ShadeCubeOnConfirm(
                                horizontalPoseArray[j+0],
                                horizontalPoseArray[j+1],
                                horizontalPoseArray[j+2],
                                horizontalPoseArray[j+3],
                                verticalPoseArray[j+0],
                                verticalPoseArray[j+1],
                                verticalPoseArray[j+2],
                                verticalPoseArray[j+3],
                                viewmtx, projmtx);
                        }

                        //Pose p1 = getPose(mAnchors[0]);
                        //Pose p2 = getPose(mAnchors[1]);
                        //Pose p3 = getPose(mAnchors[2]);
                        //horizontalPoseArray.Add(p1);
                        //horizontalPoseArray.Add(p2);
                        //horizontalPoseArray.Add(p3);
                        //Pose p4 = Calculate4thPoint(horizontalPoseArray);
                        //horizontalPoseArray.Add(p4);
                        //drawObj(p4, mVirtualObject, viewmtx, projmtx, lightIntensity);
                        //verticalPoseArray = CalculateVerticalPoseArray(horizontalPoseArray, DEFAULT_HEIGHT);

                        //// Draw full cube on confirm
                        //drawLine(verticalPoseArray[0], verticalPoseArray[1], viewmtx, projmtx);
                        //drawLine(verticalPoseArray[1], verticalPoseArray[2], viewmtx, projmtx);
                        //drawLine(verticalPoseArray[2], verticalPoseArray[3], viewmtx, projmtx);
                        //drawLine(verticalPoseArray[3], verticalPoseArray[0], viewmtx, projmtx);

                        //drawLine(horizontalPoseArray[0], verticalPoseArray[0], viewmtx, projmtx);
                        //drawLine(horizontalPoseArray[1], verticalPoseArray[1], viewmtx, projmtx);
                        //drawLine(horizontalPoseArray[2], verticalPoseArray[2], viewmtx, projmtx);
                        //drawLine(horizontalPoseArray[3], verticalPoseArray[3], viewmtx, projmtx);

                        
                    }
                    

                    // changes - End

                    // Show Length
                    //String result = sb.ToString().Replace("[+]", "") + " = " + (((int)(total * 10f)) / 10f) + "cm";
                    int displayIndex = boxModelList.Count - 1; //display latest added box dimensions
                    if (isUpdated == true)
                    {
                        String result = "\t\t\tDIMENSIONS: \n■■■■■■■■■■■■\n";
                        result = result + "\t\t\t\tLength: " + boxModelList[displayIndex].Length + "cm\n" +
                        "\t\t\t\tBreadth: " + boxModelList[displayIndex].Breadth + "cm\n" +
                        "\t\t\t\tHeight: " + boxModelList[displayIndex].Height + "cm\n" + //"---Log:manchors.count = " + mAnchors.Count +
                        "\t\t\t\tBase Area: " + boxModelList[displayIndex].Length * boxModelList[displayIndex].Breadth + "sq.cm\n" +
                        "\t\t\t\tVolume: " + boxModelList[displayIndex].Length * boxModelList[displayIndex].Breadth * boxModelList[displayIndex].Height + "cc";
                        // UpdateMessage(result);
                        UpdateBottomTextView(result);
                        isUpdated = false;

                        //int index = boxModelList.Count - 1;
                        //var tempIndex = index + 1;
                        var tempString = "Box" + boxModelList.Count.ToString() + "\n\tLength: " + boxModelList[displayIndex].Length.ToString() + "cm\n" +
                        "\tBreadth: " + boxModelList[displayIndex].Breadth.ToString() + "cm\n" +
                        "\tHeight: " + boxModelList[displayIndex].Height.ToString() + "cm\n" +
                        "\tBase Area: " + (boxModelList[displayIndex].Length * boxModelList[displayIndex].Breadth).ToString() + "sq.cm\n" +
                        "\tVolume: " + (boxModelList[displayIndex].Length * boxModelList[displayIndex].Breadth * boxModelList[displayIndex].Height).ToString() + "cc\n";
                        boxModelStringList.Add(tempString);
                        // mAnchors.Clear();

                        BoxListClass.boxModelStaticList = boxModelStringList;
                    }
                }



                // Visualize anchors created by touch.
                float scaleFactor = 1.0f;
                foreach (var anchor in mAnchors)
                {
                    if (anchor.TrackingState != TrackingState.Tracking)
                        continue;

                    // Get the current combined pose of an Anchor and Plane in world space. The Anchor
                    // and Plane poses are updated during calls to session.update() as ARCore refines
                    // its estimate of the world.
                    anchor.Pose.ToMatrix(mAnchorMatrix, 0);

                    // Update and draw the model and its shadow.
                    //mVirtualObject.updateModelMatrix(mAnchorMatrix, scaleFactor);
                    //mVirtualObjectShadow.updateModelMatrix(mAnchorMatrix, scaleFactor);
                    //mVirtualObject.Draw(viewmtx, projmtx, lightIntensity);
                    //mVirtualObjectShadow.Draw(viewmtx, projmtx, lightIntensity);
                }
            }
            catch (System.Exception ex)
            {
                // Avoid crashing the application due to unhandled exceptions.
                Log.Error(TAG, "Exception on the OpenGL thread", ex);
            }
        }

        private void ShowHelp()
        {
            if (mAnchors.Count < 1)
            {
                UpdateTopTextView("\t\t\tTap to set base point");

            }
            else if (mAnchors.Count == 1)
            {
                UpdateTopTextView("\t\t\tTap to set length");
            }
            else if (mAnchors.Count == 2)
            {
                UpdateTopTextView("\t\t\tTap to set breadth");
            }
            else if (mAnchors.Count == 3)
            {
                UpdateTopTextView("\t\t\tTap to set height");
            }
            else if (mAnchors.Count > 3)
            {
                UpdateTopTextView("\t\t\tYour box is packaged!");
                MakeToast("DONE");
            }
        }

        private void ShadeAllPolygons(List<Pose> horizontalPoseArray, List<Pose> verticalPoseArray, float[] viewmtx, float[] projmtx)
        {
            //Base Polygon
            Pose midPointPose1 = GetPoseMidpoint(horizontalPoseArray[0], horizontalPoseArray[1]);
            Pose midPointPose2 = GetPoseMidpoint(horizontalPoseArray[2], horizontalPoseArray[3]);
            float thickness = (float)getDistance(horizontalPoseArray[0], horizontalPoseArray[1]);
            DrawThickLine(midPointPose1, midPointPose2, viewmtx, projmtx, thickness);
        }

        private Pose GetPoseMidpoint(Pose pose1, Pose pose2)
        {
            var val1 = (pose2.Tx() + pose1.Tx()) / 2;
            var val2 = (pose2.Tz() + pose1.Tz()) / 2;

            Pose pose = Pose.MakeTranslation(val1, pose1.Ty(), val2);
            return pose;
        }

        //private void DrawFullCubeOnConfirm(List<Pose> horizontalPoseArray, List<Pose> verticalPoseArray)
        //{
            
        //}

        private List<Pose> CalculateVerticalPoseArray(Pose pose1, Pose pose2, Pose pose3, Pose pose4, float height)
        {
            List<Pose> vPoseArray = new List<Pose>();
            vPoseArray.Add(Pose.MakeTranslation(pose1.Tx(), pose1.Ty() + height, pose1.Tz()));
            vPoseArray.Add(Pose.MakeTranslation(pose2.Tx(), pose2.Ty() + height, pose2.Tz()));
            vPoseArray.Add(Pose.MakeTranslation(pose3.Tx(), pose3.Ty() + height, pose3.Tz()));
            vPoseArray.Add(Pose.MakeTranslation(pose4.Tx(), pose4.Ty() + height, pose4.Tz()));
            return vPoseArray;
        }

        private Pose Calculate4thPoint(Pose pose1, Pose pose2, Pose pose3)
        {
            float xvalue = pose1.Tx() + (pose3.Tx() - pose2.Tx());
            float yvalue = pose1.Ty();  // vertical
            float zvalue = pose3.Tz() - (pose2.Tz() - pose1.Tz()); ;
            Pose point4 = Pose.MakeTranslation(xvalue, yvalue, zvalue);
            return point4;
        }

        

        private float[] mPoseTranslation = new float[3];
        private float[] mPoseRotation = new float[4];

        private Pose getPose(Anchor anchor)
        {
            Pose pose = anchor.Pose;
            pose.GetTranslation(mPoseTranslation, 0);
            pose.GetRotationQuaternion(mPoseRotation, 0);
            return new Pose(mPoseTranslation, mPoseRotation);
        }

        private void drawObj(Pose pose, ObjectRenderer renderer, float[] cameraView, float[] cameraPerspective, float lightIntensity)
        {
            pose.ToMatrix(anchorMatrix, 0);
            renderer.updateModelMatrix(anchorMatrix, SCALE_FACTOR);
            renderer.Draw(cameraView, cameraPerspective, lightIntensity);
        }

        private double getDistance(Pose pose0, Pose pose1)
        {
            float dx = pose0.Tx() - pose1.Tx();
            float dy = pose0.Ty() - pose1.Ty();
            float dz = pose0.Tz() - pose1.Tz();
            return Math.Sqrt(dx * dx + dz * dz + dy * dy);
        }

        private void drawLine(Pose pose0, Pose pose1, float[] viewmtx, float[] projmtx)
        {
            float lineWidth = 0.01f;
            float lineWidthH = lineWidth / viewHeight * viewWidth;
            //float lineWidth = 0.002f;
            //float lineWidthH = 0.001f;
            rectRenderer.setVerts(
                    pose0.Tx() - lineWidth, pose0.Ty() + lineWidthH, pose0.Tz() - lineWidth,
                    pose0.Tx() + lineWidth, pose0.Ty() + lineWidthH, pose0.Tz() + lineWidth,
                    pose1.Tx() + lineWidth, pose1.Ty() + lineWidthH, pose1.Tz() + lineWidth,
                    pose1.Tx() - lineWidth, pose1.Ty() + lineWidthH, pose1.Tz() - lineWidth
                    ,
                    pose0.Tx() - lineWidth, pose0.Ty() - lineWidthH, pose0.Tz() - lineWidth,
                    pose0.Tx() + lineWidth, pose0.Ty() - lineWidthH, pose0.Tz() + lineWidth,
                    pose1.Tx() + lineWidth, pose1.Ty() - lineWidthH, pose1.Tz() + lineWidth,
                    pose1.Tx() - lineWidth, pose1.Ty() - lineWidthH, pose1.Tz() - lineWidth
            );
            
            // float[] color = { 0.89f, 0.345f, 0.345f, 0.4f }; // red
            float[] color = { 0.6196f, 0.4627f, 0.2745f, 0.4f }; // red
            //float[] color = { 0.619609f‬, 0.462745‬, 0.274510f‬, 1.0f };
            rectRenderer.SetColor(color);
            rectRenderer.draw(viewmtx, projmtx, this);
        }

        private void DrawThickLine(Pose pose0, Pose pose1, float[] viewmtx, float[] projmtx, float thickness)
        {
            float lineWidth = 0.02f;
            float lineWidthH = 0.001f; //lineWidth / viewHeight * viewWidth;
            rectRenderer.setVerts(
                    pose0.Tx() - lineWidth, pose0.Ty() + lineWidthH, pose0.Tz() - lineWidth,
                    pose0.Tx() + lineWidth, pose0.Ty() + lineWidthH, pose0.Tz() + lineWidth,
                    pose1.Tx() + lineWidth, pose1.Ty() + lineWidthH, pose1.Tz() + lineWidth,
                    pose1.Tx() - lineWidth, pose1.Ty() + lineWidthH, pose1.Tz() - lineWidth
                    ,
                    pose0.Tx() - lineWidth, pose0.Ty() - lineWidthH, pose0.Tz() - lineWidth,
                    pose0.Tx() + lineWidth, pose0.Ty() - lineWidthH, pose0.Tz() + lineWidth,
                    pose1.Tx() + lineWidth, pose1.Ty() - lineWidthH, pose1.Tz() + lineWidth,
                    pose1.Tx() - lineWidth, pose1.Ty() - lineWidthH, pose1.Tz() - lineWidth
            );
            var textureBitmap = Android.Graphics.BitmapFactory.DecodeStream(
                this.Assets.Open("red_texture.png"));
            rectRenderer.draw(viewmtx, projmtx, this);
        }

        private void DrawThickLinePoly(Pose pose0, Pose pose1, Pose pose2, Pose pose3, float[] viewmtx, float[] projmtx)
        {
            // float lineWidth = 0.02f;
            float lineWidthH = 0.001f; //lineWidth / viewHeight * viewWidth;
            rectRenderer.setVerts(
                    pose0.Tx(), pose0.Ty() + lineWidthH, pose0.Tz(),
                    pose1.Tx(), pose0.Ty() + lineWidthH, pose1.Tz(),
                    pose2.Tx(), pose1.Ty() + lineWidthH, pose2.Tz(),
                    pose3.Tx(), pose1.Ty() + lineWidthH, pose3.Tz()
                    ,
                    pose0.Tx(), pose0.Ty() - lineWidthH, pose0.Tz(),
                    pose1.Tx(), pose0.Ty() - lineWidthH, pose1.Tz(),
                    pose2.Tx(), pose1.Ty() - lineWidthH, pose2.Tz(),
                    pose3.Tx(), pose1.Ty() - lineWidthH, pose3.Tz()
            );
            var textureBitmap = Android.Graphics.BitmapFactory.DecodeStream(
                this.Assets.Open("red_texture.png"));
            rectRenderer.draw(viewmtx, projmtx, this);
        }

        //private void ShadeCubeOnConfirm(List<Pose> horizontalPoseArray, List<Pose> verticalPoseArray, float[] viewmtx, float[] projmtx)
        //{
        //    rectRenderer.setVerts(
        //            horizontalPoseArray[0].Tx(), horizontalPoseArray[0].Ty(), horizontalPoseArray[0].Tz(),
        //            horizontalPoseArray[1].Tx(), horizontalPoseArray[1].Ty(), horizontalPoseArray[1].Tz(),
        //            horizontalPoseArray[2].Tx(), horizontalPoseArray[2].Ty(), horizontalPoseArray[2].Tz(),
        //            horizontalPoseArray[3].Tx(), horizontalPoseArray[3].Ty(), horizontalPoseArray[3].Tz()
        //            ,
        //            verticalPoseArray[0].Tx(), verticalPoseArray[0].Ty(), verticalPoseArray[0].Tz(),
        //            verticalPoseArray[1].Tx(), verticalPoseArray[1].Ty(), verticalPoseArray[1].Tz(),
        //            verticalPoseArray[2].Tx(), verticalPoseArray[2].Ty(), verticalPoseArray[2].Tz(),
        //            verticalPoseArray[3].Tx(), verticalPoseArray[3].Ty(), verticalPoseArray[3].Tz()
        //    );
        //    // float[] color = { 0.63671875f, 0.76953125f, 0.22265625f, 1.0f }; // yellow
        //    float[] color = { 0.8196f, 0.6823f, 0.5176f, 1.0f };  
        //    // float[] color = { 0.819608f, 0.682353‬, 0.517647f, 1.0f };
        //    rectRenderer.SetColor(color);

        //    rectRenderer.draw(viewmtx, projmtx, this);
        //}

        private void ShadeCubeOnConfirm(Pose hPose1, Pose hPose2, Pose hPose3, Pose hPose4, Pose vPose1, Pose vPose2, Pose vPose3, Pose vPose4, float[] viewmtx, float[] projmtx)
        {
            rectRenderer.setVerts(
                    hPose1.Tx(), hPose1.Ty(), hPose1.Tz(),
                    hPose2.Tx(), hPose2.Ty(), hPose2.Tz(),
                    hPose3.Tx(), hPose3.Ty(), hPose3.Tz(),
                    hPose4.Tx(), hPose4.Ty(), hPose4.Tz()
                    ,
                    vPose1.Tx(), vPose1.Ty(), vPose1.Tz(),
                    vPose2.Tx(), vPose2.Ty(), vPose2.Tz(),
                    vPose3.Tx(), vPose3.Ty(), vPose3.Tz(),
                    vPose4.Tx(), vPose4.Ty(), vPose4.Tz()
            );
            // float[] color = { 0.63671875f, 0.76953125f, 0.22265625f, 1.0f }; // yellow
            float[] color = { 0.8196f, 0.6823f, 0.5176f, 1.0f };
            // float[] color = { 0.819608f, 0.682353‬, 0.517647f, 1.0f };
            rectRenderer.SetColor(color);

            rectRenderer.draw(viewmtx, projmtx, this);

        }

        private void ShowCompleteButton()
        {
            viewButton = new Button(this);
            viewButton.Text = "View all boxes";
            viewButton.BringToFront();
            //viewButton.SetBackgroundColor(Android.Graphics.Color.Cyan);
            //viewButton.SetTextColor(Android.Graphics.Color.Black);
            //Android.Content.Intent myIntent = new Android.Content.Intent(this, typeof(ListActivity));
            //myIntent.PutExtra("boxList", boxModelStringList.ToArray());
            viewButton.Click += delegate { StartActivity(typeof(DisplayActivity)); };
            FrameLayout.LayoutParams params1 = new FrameLayout.LayoutParams(RelativeLayout.LayoutParams.WrapContent, RelativeLayout.LayoutParams.WrapContent);
            params1.SetMargins(400,1550,0,0); // = GravityFlags.CenterVertical;
            AddContentView(viewButton, params1);
        }

        private void showLoadingMessage()
        {
            this.RunOnUiThread(() =>
            {
                mLoadingMessageSnackbar = Snackbar.Make(FindViewById(Android.Resource.Id.Content),
                        "Searching for surfaces...", Snackbar.LengthIndefinite);
                //mLoadingMessageSnackbar.View.SetBackgroundColor(Android.Graphics.Color.Rgb(205, 245, 250));
                mLoadingMessageSnackbar.View.SetBackgroundColor(Android.Graphics.Color.Black);
                mLoadingMessageSnackbar.Show();
            });
        }

        private void UpdateMessage(string result)
        {

            this.RunOnUiThread(() =>
            {
                mLoadingMessageSnackbar.SetText(result);
                mLoadingMessageSnackbar.View.SetBackgroundColor(Android.Graphics.Color.Black);
                mLoadingMessageSnackbar.View.TextAlignment = TextAlignment.Center;
                Snackbar.SnackbarLayout layout = (Snackbar.SnackbarLayout)mLoadingMessageSnackbar.View;
                layout.SetMinimumHeight(300);
            });
        }
        private void ShowTopMessage()
        {
            this.RunOnUiThread(() =>
            {
                string message = "Searching for surfaces...";
                mTopMessageSnackBar = Snackbar.Make(FindViewById(Android.Resource.Id.Content), message, Snackbar.LengthLong);
                mTopMessageSnackBar.View.SetBackgroundColor(Android.Graphics.Color.Black);
                mTopMessageSnackBar.View.TextAlignment = TextAlignment.Center;
                //View view = mTopMessageSnackBar.View;
                //FrameLayout.LayoutParams params1 = (FrameLayout.LayoutParams)view.LayoutParameters;
                //params1.Gravity = GravityFlags.Top; // Top - 48
                //view.LayoutParameters = params1;
                Snackbar.SnackbarLayout layout = (Snackbar.SnackbarLayout)mTopMessageSnackBar.View;
                layout.SetMinimumHeight(150);
                mTopMessageSnackBar.Show();
            });
        }

        private void UpdateTopMessage()
        {
            string message = "";
            
            this.RunOnUiThread(() =>
            {
                mTopMessageSnackBar.SetText(message);
            });
        }

        private void UpdateTopMessageToBottom(string result)
        {
            //mTopMessageSnackBar.Dismiss();
            //mTopMessageSnackBar = null;
            // mTopMessageSnackBar = Snackbar.Make(FindViewById(Android.Resource.Id.Content), result, Snackbar.LengthLong);
            mTopMessageSnackBar.SetText(result);
            mTopMessageSnackBar.View.SetBackgroundColor(Android.Graphics.Color.Black);
            mTopMessageSnackBar.View.TextAlignment = TextAlignment.Center;

            //View view = mTopMessageSnackBar.View;
            //FrameLayout.LayoutParams params1 = (FrameLayout.LayoutParams)view.LayoutParameters;
            //params1.Gravity = GravityFlags.Bottom; // Top - 48
            //view.LayoutParameters = params1;

            Snackbar.SnackbarLayout layout = (Snackbar.SnackbarLayout)mTopMessageSnackBar.View;
            layout.SetMinimumHeight(300);
        }

            private void hideLoadingMessage()
        {
            this.RunOnUiThread(() =>
            {
                mLoadingMessageSnackbar.Dismiss();
                mLoadingMessageSnackbar = null;
            });

        }

        public bool OnTouch(View v, MotionEvent e)
        {
            return mGestureDetector.OnTouchEvent(e);
        }
    }
    
    class SimpleTapGestureDetector : GestureDetector.SimpleOnGestureListener
    {
        public Func<MotionEvent, bool> SingleTapUpHandler { get; set; }

        public override bool OnSingleTapUp(MotionEvent e)
        {
            return SingleTapUpHandler?.Invoke(e) ?? false;
        }

        public Func<MotionEvent, bool> DownHandler { get; set; }

        public override bool OnDown(MotionEvent e)
        {
            return DownHandler?.Invoke(e) ?? false;
        }
    }
}
