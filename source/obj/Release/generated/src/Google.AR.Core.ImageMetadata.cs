using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']"
	[global::Android.Runtime.Register ("com/google/ar/core/ImageMetadata", DoNotGenerateAcw=true)]
	public partial class ImageMetadata : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='BLACK_LEVEL_LOCK']"
		[Register ("BLACK_LEVEL_LOCK")]
		public const int BlackLevelLock = (int) 1441792;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='COLOR_CORRECTION_ABERRATION_MODE']"
		[Register ("COLOR_CORRECTION_ABERRATION_MODE")]
		public const int ColorCorrectionAberrationMode = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='COLOR_CORRECTION_GAINS']"
		[Register ("COLOR_CORRECTION_GAINS")]
		public const int ColorCorrectionGains = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='COLOR_CORRECTION_MODE']"
		[Register ("COLOR_CORRECTION_MODE")]
		public const int ColorCorrectionMode = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='COLOR_CORRECTION_TRANSFORM']"
		[Register ("COLOR_CORRECTION_TRANSFORM")]
		public const int ColorCorrectionTransform = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='CONTROL_AE_ANTIBANDING_MODE']"
		[Register ("CONTROL_AE_ANTIBANDING_MODE")]
		public const int ControlAeAntibandingMode = (int) 65536;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='CONTROL_AE_EXPOSURE_COMPENSATION']"
		[Register ("CONTROL_AE_EXPOSURE_COMPENSATION")]
		public const int ControlAeExposureCompensation = (int) 65537;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='CONTROL_AE_LOCK']"
		[Register ("CONTROL_AE_LOCK")]
		public const int ControlAeLock = (int) 65538;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='CONTROL_AE_MODE']"
		[Register ("CONTROL_AE_MODE")]
		public const int ControlAeMode = (int) 65539;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='CONTROL_AE_PRECAPTURE_TRIGGER']"
		[Register ("CONTROL_AE_PRECAPTURE_TRIGGER")]
		public const int ControlAePrecaptureTrigger = (int) 65542;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='CONTROL_AE_REGIONS']"
		[Register ("CONTROL_AE_REGIONS")]
		public const int ControlAeRegions = (int) 65540;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='CONTROL_AE_STATE']"
		[Register ("CONTROL_AE_STATE")]
		public const int ControlAeState = (int) 65567;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='CONTROL_AE_TARGET_FPS_RANGE']"
		[Register ("CONTROL_AE_TARGET_FPS_RANGE")]
		public const int ControlAeTargetFpsRange = (int) 65541;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='CONTROL_AF_MODE']"
		[Register ("CONTROL_AF_MODE")]
		public const int ControlAfMode = (int) 65543;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='CONTROL_AF_REGIONS']"
		[Register ("CONTROL_AF_REGIONS")]
		public const int ControlAfRegions = (int) 65544;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='CONTROL_AF_STATE']"
		[Register ("CONTROL_AF_STATE")]
		public const int ControlAfState = (int) 65568;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='CONTROL_AF_TRIGGER']"
		[Register ("CONTROL_AF_TRIGGER")]
		public const int ControlAfTrigger = (int) 65545;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='CONTROL_AWB_LOCK']"
		[Register ("CONTROL_AWB_LOCK")]
		public const int ControlAwbLock = (int) 65546;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='CONTROL_AWB_MODE']"
		[Register ("CONTROL_AWB_MODE")]
		public const int ControlAwbMode = (int) 65547;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='CONTROL_AWB_REGIONS']"
		[Register ("CONTROL_AWB_REGIONS")]
		public const int ControlAwbRegions = (int) 65548;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='CONTROL_AWB_STATE']"
		[Register ("CONTROL_AWB_STATE")]
		public const int ControlAwbState = (int) 65570;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='CONTROL_CAPTURE_INTENT']"
		[Register ("CONTROL_CAPTURE_INTENT")]
		public const int ControlCaptureIntent = (int) 65549;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='CONTROL_EFFECT_MODE']"
		[Register ("CONTROL_EFFECT_MODE")]
		public const int ControlEffectMode = (int) 65550;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='CONTROL_MODE']"
		[Register ("CONTROL_MODE")]
		public const int ControlMode = (int) 65551;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='CONTROL_POST_RAW_SENSITIVITY_BOOST']"
		[Register ("CONTROL_POST_RAW_SENSITIVITY_BOOST")]
		public const int ControlPostRawSensitivityBoost = (int) 65576;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='CONTROL_SCENE_MODE']"
		[Register ("CONTROL_SCENE_MODE")]
		public const int ControlSceneMode = (int) 65552;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='CONTROL_VIDEO_STABILIZATION_MODE']"
		[Register ("CONTROL_VIDEO_STABILIZATION_MODE")]
		public const int ControlVideoStabilizationMode = (int) 65553;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='EDGE_MODE']"
		[Register ("EDGE_MODE")]
		public const int EdgeMode = (int) 196608;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='FLASH_MODE']"
		[Register ("FLASH_MODE")]
		public const int FlashMode = (int) 262146;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='FLASH_STATE']"
		[Register ("FLASH_STATE")]
		public const int FlashState = (int) 262149;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='HOT_PIXEL_MODE']"
		[Register ("HOT_PIXEL_MODE")]
		public const int HotPixelMode = (int) 393216;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='JPEG_GPS_COORDINATES']"
		[Register ("JPEG_GPS_COORDINATES")]
		public const int JpegGpsCoordinates = (int) 458752;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='JPEG_GPS_PROCESSING_METHOD']"
		[Register ("JPEG_GPS_PROCESSING_METHOD")]
		public const int JpegGpsProcessingMethod = (int) 458753;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='JPEG_GPS_TIMESTAMP']"
		[Register ("JPEG_GPS_TIMESTAMP")]
		public const int JpegGpsTimestamp = (int) 458754;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='JPEG_ORIENTATION']"
		[Register ("JPEG_ORIENTATION")]
		public const int JpegOrientation = (int) 458755;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='JPEG_QUALITY']"
		[Register ("JPEG_QUALITY")]
		public const int JpegQuality = (int) 458756;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='JPEG_THUMBNAIL_QUALITY']"
		[Register ("JPEG_THUMBNAIL_QUALITY")]
		public const int JpegThumbnailQuality = (int) 458757;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='JPEG_THUMBNAIL_SIZE']"
		[Register ("JPEG_THUMBNAIL_SIZE")]
		public const int JpegThumbnailSize = (int) 458758;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='LENS_APERTURE']"
		[Register ("LENS_APERTURE")]
		public const int LensAperture = (int) 524288;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='LENS_FILTER_DENSITY']"
		[Register ("LENS_FILTER_DENSITY")]
		public const int LensFilterDensity = (int) 524289;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='LENS_FOCAL_LENGTH']"
		[Register ("LENS_FOCAL_LENGTH")]
		public const int LensFocalLength = (int) 524290;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='LENS_FOCUS_DISTANCE']"
		[Register ("LENS_FOCUS_DISTANCE")]
		public const int LensFocusDistance = (int) 524291;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='LENS_FOCUS_RANGE']"
		[Register ("LENS_FOCUS_RANGE")]
		public const int LensFocusRange = (int) 524296;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='LENS_INTRINSIC_CALIBRATION']"
		[Register ("LENS_INTRINSIC_CALIBRATION")]
		public const int LensIntrinsicCalibration = (int) 524298;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='LENS_OPTICAL_STABILIZATION_MODE']"
		[Register ("LENS_OPTICAL_STABILIZATION_MODE")]
		public const int LensOpticalStabilizationMode = (int) 524292;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='LENS_POSE_ROTATION']"
		[Register ("LENS_POSE_ROTATION")]
		public const int LensPoseRotation = (int) 524294;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='LENS_POSE_TRANSLATION']"
		[Register ("LENS_POSE_TRANSLATION")]
		public const int LensPoseTranslation = (int) 524295;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='LENS_RADIAL_DISTORTION']"
		[Register ("LENS_RADIAL_DISTORTION")]
		public const int LensRadialDistortion = (int) 524299;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='LENS_STATE']"
		[Register ("LENS_STATE")]
		public const int LensState = (int) 524297;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='NOISE_REDUCTION_MODE']"
		[Register ("NOISE_REDUCTION_MODE")]
		public const int NoiseReductionMode = (int) 655360;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='REQUEST_PIPELINE_DEPTH']"
		[Register ("REQUEST_PIPELINE_DEPTH")]
		public const int RequestPipelineDepth = (int) 786441;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='SCALER_CROP_REGION']"
		[Register ("SCALER_CROP_REGION")]
		public const int ScalerCropRegion = (int) 851968;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='SENSOR_DYNAMIC_BLACK_LEVEL']"
		[Register ("SENSOR_DYNAMIC_BLACK_LEVEL")]
		public const int SensorDynamicBlackLevel = (int) 917532;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='SENSOR_DYNAMIC_WHITE_LEVEL']"
		[Register ("SENSOR_DYNAMIC_WHITE_LEVEL")]
		public const int SensorDynamicWhiteLevel = (int) 917533;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='SENSOR_EXPOSURE_TIME']"
		[Register ("SENSOR_EXPOSURE_TIME")]
		public const int SensorExposureTime = (int) 917504;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='SENSOR_FRAME_DURATION']"
		[Register ("SENSOR_FRAME_DURATION")]
		public const int SensorFrameDuration = (int) 917505;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='SENSOR_GREEN_SPLIT']"
		[Register ("SENSOR_GREEN_SPLIT")]
		public const int SensorGreenSplit = (int) 917526;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='SENSOR_NEUTRAL_COLOR_POINT']"
		[Register ("SENSOR_NEUTRAL_COLOR_POINT")]
		public const int SensorNeutralColorPoint = (int) 917522;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='SENSOR_NOISE_PROFILE']"
		[Register ("SENSOR_NOISE_PROFILE")]
		public const int SensorNoiseProfile = (int) 917523;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='SENSOR_ROLLING_SHUTTER_SKEW']"
		[Register ("SENSOR_ROLLING_SHUTTER_SKEW")]
		public const int SensorRollingShutterSkew = (int) 917530;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='SENSOR_SENSITIVITY']"
		[Register ("SENSOR_SENSITIVITY")]
		public const int SensorSensitivity = (int) 917506;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='SENSOR_TEST_PATTERN_DATA']"
		[Register ("SENSOR_TEST_PATTERN_DATA")]
		public const int SensorTestPatternData = (int) 917527;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='SENSOR_TEST_PATTERN_MODE']"
		[Register ("SENSOR_TEST_PATTERN_MODE")]
		public const int SensorTestPatternMode = (int) 917528;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='SENSOR_TIMESTAMP']"
		[Register ("SENSOR_TIMESTAMP")]
		public const int SensorTimestamp = (int) 917520;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='SHADING_MODE']"
		[Register ("SHADING_MODE")]
		public const int ShadingMode = (int) 1048576;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='STATISTICS_FACE_DETECT_MODE']"
		[Register ("STATISTICS_FACE_DETECT_MODE")]
		public const int StatisticsFaceDetectMode = (int) 1114112;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='STATISTICS_FACE_IDS']"
		[Register ("STATISTICS_FACE_IDS")]
		public const int StatisticsFaceIds = (int) 1114116;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='STATISTICS_FACE_LANDMARKS']"
		[Register ("STATISTICS_FACE_LANDMARKS")]
		public const int StatisticsFaceLandmarks = (int) 1114117;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='STATISTICS_FACE_RECTANGLES']"
		[Register ("STATISTICS_FACE_RECTANGLES")]
		public const int StatisticsFaceRectangles = (int) 1114118;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='STATISTICS_FACE_SCORES']"
		[Register ("STATISTICS_FACE_SCORES")]
		public const int StatisticsFaceScores = (int) 1114119;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='STATISTICS_HOT_PIXEL_MAP']"
		[Register ("STATISTICS_HOT_PIXEL_MAP")]
		public const int StatisticsHotPixelMap = (int) 1114127;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='STATISTICS_HOT_PIXEL_MAP_MODE']"
		[Register ("STATISTICS_HOT_PIXEL_MAP_MODE")]
		public const int StatisticsHotPixelMapMode = (int) 1114115;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='STATISTICS_LENS_SHADING_MAP']"
		[Register ("STATISTICS_LENS_SHADING_MAP")]
		public const int StatisticsLensShadingMap = (int) 1114123;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='STATISTICS_LENS_SHADING_MAP_MODE']"
		[Register ("STATISTICS_LENS_SHADING_MAP_MODE")]
		public const int StatisticsLensShadingMapMode = (int) 1114128;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='STATISTICS_SCENE_FLICKER']"
		[Register ("STATISTICS_SCENE_FLICKER")]
		public const int StatisticsSceneFlicker = (int) 1114126;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='SYNC_FRAME_NUMBER']"
		[Register ("SYNC_FRAME_NUMBER")]
		public const int SyncFrameNumber = (int) 1507328;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='TONEMAP_CURVE_BLUE']"
		[Register ("TONEMAP_CURVE_BLUE")]
		public const int TonemapCurveBlue = (int) 1245184;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='TONEMAP_CURVE_GREEN']"
		[Register ("TONEMAP_CURVE_GREEN")]
		public const int TonemapCurveGreen = (int) 1245185;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='TONEMAP_CURVE_RED']"
		[Register ("TONEMAP_CURVE_RED")]
		public const int TonemapCurveRed = (int) 1245186;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='TONEMAP_GAMMA']"
		[Register ("TONEMAP_GAMMA")]
		public const int TonemapGamma = (int) 1245190;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='TONEMAP_MODE']"
		[Register ("TONEMAP_MODE")]
		public const int TonemapMode = (int) 1245187;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/field[@name='TONEMAP_PRESET_CURVE']"
		[Register ("TONEMAP_PRESET_CURVE")]
		public const int TonemapPresetCurve = (int) 1245191;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/google/ar/core/ImageMetadata", typeof (ImageMetadata));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected ImageMetadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/constructor[@name='ImageMetadata' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe ImageMetadata ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getByte_I;
#pragma warning disable 0169
		static Delegate GetGetByte_IHandler ()
		{
			if (cb_getByte_I == null)
				cb_getByte_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, sbyte>) n_GetByte_I);
			return cb_getByte_I;
		}

		static sbyte n_GetByte_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Google.AR.Core.ImageMetadata __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ImageMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetByte (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/method[@name='getByte' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getByte", "(I)B", "GetGetByte_IHandler")]
		public virtual unsafe sbyte GetByte (int p0)
		{
			const string __id = "getByte.(I)B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getByteArray_I;
#pragma warning disable 0169
		static Delegate GetGetByteArray_IHandler ()
		{
			if (cb_getByteArray_I == null)
				cb_getByteArray_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetByteArray_I);
			return cb_getByteArray_I;
		}

		static IntPtr n_GetByteArray_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Google.AR.Core.ImageMetadata __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ImageMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetByteArray (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/method[@name='getByteArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getByteArray", "(I)[B", "GetGetByteArray_IHandler")]
		public virtual unsafe byte[] GetByteArray (int p0)
		{
			const string __id = "getByteArray.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getDouble_I;
#pragma warning disable 0169
		static Delegate GetGetDouble_IHandler ()
		{
			if (cb_getDouble_I == null)
				cb_getDouble_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_GetDouble_I);
			return cb_getDouble_I;
		}

		static double n_GetDouble_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Google.AR.Core.ImageMetadata __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ImageMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetDouble (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/method[@name='getDouble' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDouble", "(I)D", "GetGetDouble_IHandler")]
		public virtual unsafe double GetDouble (int p0)
		{
			const string __id = "getDouble.(I)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getDoubleArray_I;
#pragma warning disable 0169
		static Delegate GetGetDoubleArray_IHandler ()
		{
			if (cb_getDoubleArray_I == null)
				cb_getDoubleArray_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetDoubleArray_I);
			return cb_getDoubleArray_I;
		}

		static IntPtr n_GetDoubleArray_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Google.AR.Core.ImageMetadata __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ImageMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDoubleArray (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/method[@name='getDoubleArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDoubleArray", "(I)[D", "GetGetDoubleArray_IHandler")]
		public virtual unsafe double[] GetDoubleArray (int p0)
		{
			const string __id = "getDoubleArray.(I)[D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (double[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_getFloat_I;
#pragma warning disable 0169
		static Delegate GetGetFloat_IHandler ()
		{
			if (cb_getFloat_I == null)
				cb_getFloat_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, float>) n_GetFloat_I);
			return cb_getFloat_I;
		}

		static float n_GetFloat_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Google.AR.Core.ImageMetadata __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ImageMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetFloat (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/method[@name='getFloat' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getFloat", "(I)F", "GetGetFloat_IHandler")]
		public virtual unsafe float GetFloat (int p0)
		{
			const string __id = "getFloat.(I)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getFloatArray_I;
#pragma warning disable 0169
		static Delegate GetGetFloatArray_IHandler ()
		{
			if (cb_getFloatArray_I == null)
				cb_getFloatArray_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetFloatArray_I);
			return cb_getFloatArray_I;
		}

		static IntPtr n_GetFloatArray_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Google.AR.Core.ImageMetadata __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ImageMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetFloatArray (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/method[@name='getFloatArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getFloatArray", "(I)[F", "GetGetFloatArray_IHandler")]
		public virtual unsafe float[] GetFloatArray (int p0)
		{
			const string __id = "getFloatArray.(I)[F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getInt_I;
#pragma warning disable 0169
		static Delegate GetGetInt_IHandler ()
		{
			if (cb_getInt_I == null)
				cb_getInt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetInt_I);
			return cb_getInt_I;
		}

		static int n_GetInt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Google.AR.Core.ImageMetadata __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ImageMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetInt (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/method[@name='getInt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getInt", "(I)I", "GetGetInt_IHandler")]
		public virtual unsafe int GetInt (int p0)
		{
			const string __id = "getInt.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getIntArray_I;
#pragma warning disable 0169
		static Delegate GetGetIntArray_IHandler ()
		{
			if (cb_getIntArray_I == null)
				cb_getIntArray_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetIntArray_I);
			return cb_getIntArray_I;
		}

		static IntPtr n_GetIntArray_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Google.AR.Core.ImageMetadata __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ImageMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetIntArray (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/method[@name='getIntArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getIntArray", "(I)[I", "GetGetIntArray_IHandler")]
		public virtual unsafe int[] GetIntArray (int p0)
		{
			const string __id = "getIntArray.(I)[I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getKeys;
#pragma warning disable 0169
		static Delegate GetGetKeysHandler ()
		{
			if (cb_getKeys == null)
				cb_getKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKeys);
			return cb_getKeys;
		}

		static IntPtr n_GetKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.ImageMetadata __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ImageMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetKeys ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/method[@name='getKeys' and count(parameter)=0]"
		[Register ("getKeys", "()[J", "GetGetKeysHandler")]
		public virtual unsafe long[] GetKeys ()
		{
			const string __id = "getKeys.()[J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (long[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (long));
			} finally {
			}
		}

		static Delegate cb_getLong_I;
#pragma warning disable 0169
		static Delegate GetGetLong_IHandler ()
		{
			if (cb_getLong_I == null)
				cb_getLong_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetLong_I);
			return cb_getLong_I;
		}

		static long n_GetLong_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Google.AR.Core.ImageMetadata __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ImageMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetLong (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/method[@name='getLong' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getLong", "(I)J", "GetGetLong_IHandler")]
		public virtual unsafe long GetLong (int p0)
		{
			const string __id = "getLong.(I)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getLongArray_I;
#pragma warning disable 0169
		static Delegate GetGetLongArray_IHandler ()
		{
			if (cb_getLongArray_I == null)
				cb_getLongArray_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetLongArray_I);
			return cb_getLongArray_I;
		}

		static IntPtr n_GetLongArray_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Google.AR.Core.ImageMetadata __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ImageMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLongArray (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/method[@name='getLongArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getLongArray", "(I)[J", "GetGetLongArray_IHandler")]
		public virtual unsafe long[] GetLongArray (int p0)
		{
			const string __id = "getLongArray.(I)[J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (long[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (long));
			} finally {
			}
		}

		static Delegate cb_getRational_I;
#pragma warning disable 0169
		static Delegate GetGetRational_IHandler ()
		{
			if (cb_getRational_I == null)
				cb_getRational_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetRational_I);
			return cb_getRational_I;
		}

		static IntPtr n_GetRational_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Google.AR.Core.ImageMetadata __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ImageMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetRational (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/method[@name='getRational' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getRational", "(I)Landroid/util/Rational;", "GetGetRational_IHandler")]
		public virtual unsafe global::Android.Util.Rational GetRational (int p0)
		{
			const string __id = "getRational.(I)Landroid/util/Rational;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.Rational> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getRationalArray_I;
#pragma warning disable 0169
		static Delegate GetGetRationalArray_IHandler ()
		{
			if (cb_getRationalArray_I == null)
				cb_getRationalArray_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetRationalArray_I);
			return cb_getRationalArray_I;
		}

		static IntPtr n_GetRationalArray_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Google.AR.Core.ImageMetadata __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ImageMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRationalArray (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ImageMetadata']/method[@name='getRationalArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getRationalArray", "(I)[Landroid/util/Rational;", "GetGetRationalArray_IHandler")]
		public virtual unsafe global::Android.Util.Rational[] GetRationalArray (int p0)
		{
			const string __id = "getRationalArray.(I)[Landroid/util/Rational;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Android.Util.Rational[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Android.Util.Rational));
			} finally {
			}
		}

	}
}
