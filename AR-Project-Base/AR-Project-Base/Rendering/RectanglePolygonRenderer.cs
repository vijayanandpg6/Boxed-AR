using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
// using Android.Graphics;
using Android.Opengl;
using Android.OS;
using Android.Renderscripts;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Nio;

namespace AR_Project_Base.Rendering
{
    class RectanglePolygonRenderer
    {
        private FloatBuffer vertexBuffer;
        private ShortBuffer drawListBuffer;

        // number of coordinates pervertex in this array
        static int COORDS_PER_VERTEX = 3;
        static float[] coords = new float[]{
            -0.6f,  0.5f, 0.2f,   // top left
            -0.4f, -0.5f, 0.2f,   // bottom left
            0.5f, -0.5f, 0.2f,   // bottom right
            0.5f,  0.5f, 0.2f,   // top right

            -0.5f,  0.6f, 0.0f,   // top left
            -0.5f, -0.8f, 0.0f,   // bottom left
            0.5f, -0.5f, 0.0f,   // bottom right
            0.5f,  0.5f, 0.0f   // top right
    };
        private short[] drawOrder = new short[]{
            0, 1, 2,  0, 2, 3,
            3, 2, 6,  3, 6, 7,
            4, 5, 6,  4, 6, 7,
            0, 1, 5,  0, 5, 4,
            4, 0, 3,  4, 3, 7,
            5, 1, 2,  5, 2, 6
    }; // order to draw vertex

        // float[] color = { 0.63671875f, 0.76953125f, 0.22265625f, 1.0f }; // yellow
        // float[] color = { 0.89f, 0.345f, 0.345f, 0.4f }; //Red color
        float[] color = { 0.50196f, 0.43529f, 0.10588f, 1.0f };

        public void SetColor(float[] colorValue)
        {
            color = colorValue;
        }

        public void setVerts(float v0, float v1, float v2,
                             float v3, float v4, float v5,
                             float v6, float v7, float v8,
                             float v9, float v10, float v11,

                             float v12, float v13, float v14,
                             float v15, float v16, float v17,
                             float v18, float v19, float v20,
                             float v21, float v22, float v23
                             )
        {
            coords[0] = v0;
            coords[1] = v1;
            coords[2] = v2;

            coords[3] = v3;
            coords[4] = v4;
            coords[5] = v5;

            coords[6] = v6;
            coords[7] = v7;
            coords[8] = v8;

            coords[9] = v9;
            coords[10] = v10;
            coords[11] = v11;

            coords[12] = v12;
            coords[13] = v13;
            coords[14] = v14;

            coords[15] = v15;
            coords[16] = v16;
            coords[17] = v17;

            coords[18] = v18;
            coords[19] = v19;
            coords[20] = v20;

            coords[21] = v21;
            coords[22] = v22;
            coords[23] = v23;

            vertexBuffer.Put(coords);
            // set the buffer to read the first coordinate
            vertexBuffer.Position(0);
        }

        public void setColor(float red, float green, float blue, float alpha)
        {
            color[0] = red;
            color[1] = green;
            color[2] = blue;
            color[3] = alpha;
        }

        // Use to access and set the view transformation
        private int mMVPMatrixHandle;

        private int mProgram;

        //private String vertexShaderCode =
        //    "uniform mat4 uMVPMatrix;" +
        //    "varying vec2 vTexCoord;" +
        //            "attribute vec4 vPosition;" +
        //            "void main() {" +
        //            "vTexCoord = vPosition.xy;" +
        //            " gl_Position = uMVPMatrix * vPosition;" +
        //            "}";

        //private String fragmentShaderCode =
        //    "precision mediump float;" +
        //    "uniform samplerExternalOES sTexture;" +
        //     "varying vec2 v_TexCoord;" +
        //            "uniform vec4 vColor;" +
        //            "void main() {" +
        //            "vColor = texture2D(sTexture, vTexCoord);" +
        //            "vColor.r = 0.5;" +
        //            "gl_FragColor = vColor;" +
        //            "}";

        //private String fragmentShaderCode = 
        //    "precision mediump float;" +
        //    "varying vec2 v_TexCoord;" +
        //    "uniform samplerExternalOES sTexture;" +
        //        "void main()" +
        //        "{" +
        //            "gl_FragColor = texture2D(sTexture, v_TexCoord);" +
        //        "}";


        private String vertexShaderCode =
                    "uniform mat4 uMVPMatrix;" +
                            "attribute vec4 vPosition;" +
                            "void main() {" +
                            " gl_Position = uMVPMatrix * vPosition;" +
                            "}";

        private String fragmentShaderCode =
            "precision mediump float;" +
            // "uniform sampler2D sTexture;" +
            // "varying vec2 vTexCoord;" +
            "uniform vec4 vColor;" +
                    // "vColor = texture2D(sTexture, vTexCoord);" +
                    "void main() {" +
                    "  gl_FragColor = vColor;" +
                    "}";

        private int mPositionHandle;
        private int mColorHandle;
        // private int mTextureHandle;

        private int vertexCount = coords.Length / COORDS_PER_VERTEX;
        private int vertexStride = COORDS_PER_VERTEX * 4;

        private int loadShader(int type, String shaderCode)
        {
            int shader = GLES20.GlCreateShader(type);
            GLES20.GlShaderSource(shader, shaderCode);
            GLES20.GlCompileShader(shader);
            return shader;
        }

        public RectanglePolygonRenderer()
        {
            // initialize vertex byte buffer for shape coordinates
            ByteBuffer bb = ByteBuffer.AllocateDirect(coords.Length * 4);
            bb.Order(ByteOrder.NativeOrder());
            vertexBuffer = bb.AsFloatBuffer();
            vertexBuffer.Put(coords);
            vertexBuffer.Position(0);

            // initialize byte buffer for the draw list
            ByteBuffer dlb = ByteBuffer.AllocateDirect(drawOrder.Length * 2);   // 2 bytes per short
            dlb.Order(ByteOrder.NativeOrder());
            drawListBuffer = dlb.AsShortBuffer();
            drawListBuffer.Put(drawOrder);
            drawListBuffer.Position(0);

            int vertexShader = loadShader(GLES20.GlVertexShader, vertexShaderCode);
            int fragmentShader = loadShader(GLES20.GlFragmentShader, fragmentShaderCode);
            // int textureShader = loadShader(GLES20.GlTexture2d, textureShaderCode);

            // create empty OpenGL ES Program
            mProgram = GLES20.GlCreateProgram();

            // add the shader to program
            GLES20.GlAttachShader(mProgram, vertexShader);
            GLES20.GlAttachShader(mProgram, fragmentShader);
            //GLES20.GlAttachShader(mProgram, textureShader);

            // create OpenGL ES program executables
            GLES20.GlLinkProgram(mProgram);
            Matrix.SetIdentityM(mModelMatrix, 0);
        }

        // Temporary matrices allocated here to reduce number of allocations for each frame.
        private float[] mModelMatrix = new float[16];
        private float[] mModelViewMatrix = new float[16];
        private float[] mModelViewProjectionMatrix = new float[16];
        String TAG = "RectanglePolygon";

        public void draw(float[] cameraView, float[] cameraPerspective, Context context)
        {
            ShaderUtil.CheckGLError(TAG, "Before draw");

            // Build the ModelView and ModelViewProjection matrices
            // for calculating object position and light.
            Matrix.MultiplyMM(mModelViewMatrix, 0, cameraView, 0, mModelMatrix, 0);
            Matrix.MultiplyMM(mModelViewProjectionMatrix, 0, cameraPerspective, 0, mModelViewMatrix, 0);

            // add program to OpenGL ES environment
            GLES20.GlUseProgram(mProgram);

            // get handle to vertex shader's vPosition member
            mPositionHandle = GLES20.GlGetAttribLocation(mProgram, "vPosition");

            // enable a handle to the triangle vertices
            GLES20.GlEnableVertexAttribArray(mPositionHandle);

            // prepare the triangle coordinate data
            GLES20.GlVertexAttribPointer(mPositionHandle, COORDS_PER_VERTEX,
                    GLES20.GlFloat, false,
                    vertexStride, vertexBuffer);

            // get handle to fragment shader's vColor member
            mColorHandle = GLES20.GlGetUniformLocation(mProgram, "vColor");
            // mTextureHandle = GLES20.GlGetUniformLocation(mProgram, "vTexCoord");

            // set color for drawing the triangle
            GLES20.GlUniform4fv(mColorHandle, 1, color, 0);

            // set texture
            // GLES20.GlUniform4fv(mTextureHandle, 1, textureBitmap.ToArray<float>(), 0);
            
            // changes - Begin
            //var textureBitmap = Android.Graphics.BitmapFactory.DecodeStream(
            //    context.Assets.Open("red_texture.png"));
            //Sampler texture1;
            //GLUtils.TexImage2D(GLES20.GlTexture2d, 0, textureBitmap, 0);
            //GLES20.GlActiveTexture(GLES20.GlTexture2d);
            //GLES20.GlBindTexture(GLES20.GlTexture2d, texture1);

            /////////
            //var colorTexture = textureBitmap.ToArray<float>();
            //GLES20.GlUniform4fv(mColorHandle, 1, colorTexture, 0);
            // GLUtils.TexImage2D(GLES20.GlTexture2d, 0, textureBitmap, 0);
            //GLES20.GlGenerateMipmap(GLES20.GlTexture2d);
            //GLES20.GlBindTexture(GLES20.GlTexture2d, 0);
            /////////
            ///
            //GLES20.GlActiveTexture(GLES20.GlTexture1);
            //GLES20.GlBindTexture(GLES20.GlTexture2d, GLES20.GlTexture10);

            //GLES20.GlActiveTexture(GLES20.GlTexture1);
            //GLES20.GlBindTexture(GLES20.GlTexture2d, GLES20.GlTexture10);


            // changes - End

            // get handle to shape's transformation matrix
            mMVPMatrixHandle = GLES20.GlGetUniformLocation(mProgram, "uMVPMatrix");

            // Pass the projection and view transformation to the shader
            GLES20.GlUniformMatrix4fv(mMVPMatrixHandle, 1, false, mModelViewProjectionMatrix, 0);

            GLES20.GlDrawElements(GLES20.GlTriangles, drawOrder.Length,
                    GLES20.GlUnsignedShort, drawListBuffer);

            // Disable vertex array
            GLES20.GlDisableVertexAttribArray(mPositionHandle);
        }
    }
}