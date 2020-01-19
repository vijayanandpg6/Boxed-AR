using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/google/ar/core",
						"com/google/ar/core/exceptions",
						"com/google/vr/dynamite/client",
					},
					new Converter<string, Type>[]{
						lookup_com_google_ar_core_package,
						lookup_com_google_ar_core_exceptions_package,
						lookup_com_google_vr_dynamite_client_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_google_ar_core_mappings;
		static Type lookup_com_google_ar_core_package (string klass)
		{
			if (package_com_google_ar_core_mappings == null) {
				package_com_google_ar_core_mappings = new string[]{
					"com/google/ar/core/Anchor:Google.AR.Core.Anchor",
					"com/google/ar/core/Anchor$CloudAnchorState:Google.AR.Core.Anchor/CloudAnchorState",
					"com/google/ar/core/ArCoreApk:Google.AR.Core.ArCoreApk",
					"com/google/ar/core/ArCoreApk$Availability:Google.AR.Core.ArCoreApk/Availability",
					"com/google/ar/core/ArCoreApk$InstallBehavior:Google.AR.Core.ArCoreApk/InstallBehavior",
					"com/google/ar/core/ArCoreApk$InstallStatus:Google.AR.Core.ArCoreApk/InstallStatus",
					"com/google/ar/core/ArCoreApk$UserMessageType:Google.AR.Core.ArCoreApk/UserMessageType",
					"com/google/ar/core/ArImage:Google.AR.Core.ArImage",
					"com/google/ar/core/AugmentedFace:Google.AR.Core.AugmentedFace",
					"com/google/ar/core/AugmentedFace$RegionType:Google.AR.Core.AugmentedFace/RegionType",
					"com/google/ar/core/AugmentedImage:Google.AR.Core.AugmentedImage",
					"com/google/ar/core/AugmentedImage$TrackingMethod:Google.AR.Core.AugmentedImage/TrackingMethod",
					"com/google/ar/core/AugmentedImageDatabase:Google.AR.Core.AugmentedImageDatabase",
					"com/google/ar/core/Camera:Google.AR.Core.Camera",
					"com/google/ar/core/CameraConfig:Google.AR.Core.CameraConfig",
					"com/google/ar/core/CameraConfig$DepthSensorUsage:Google.AR.Core.CameraConfig/DepthSensorUsage",
					"com/google/ar/core/CameraConfig$FacingDirection:Google.AR.Core.CameraConfig/FacingDirection",
					"com/google/ar/core/CameraConfig$TargetFps:Google.AR.Core.CameraConfig/TargetFps",
					"com/google/ar/core/CameraConfigFilter:Google.AR.Core.CameraConfigFilter",
					"com/google/ar/core/CameraIntrinsics:Google.AR.Core.CameraIntrinsics",
					"com/google/ar/core/Config:Google.AR.Core.Config",
					"com/google/ar/core/Config$AugmentedFaceMode:Google.AR.Core.Config/AugmentedFaceMode",
					"com/google/ar/core/Config$CloudAnchorMode:Google.AR.Core.Config/CloudAnchorMode",
					"com/google/ar/core/Config$FocusMode:Google.AR.Core.Config/FocusMode",
					"com/google/ar/core/Config$LightEstimationMode:Google.AR.Core.Config/LightEstimationMode",
					"com/google/ar/core/Config$PlaneFindingMode:Google.AR.Core.Config/PlaneFindingMode",
					"com/google/ar/core/Config$UpdateMode:Google.AR.Core.Config/UpdateMode",
					"com/google/ar/core/Coordinates2d:Google.AR.Core.Coordinates2d",
					"com/google/ar/core/Frame:Google.AR.Core.Frame",
					"com/google/ar/core/HitResult:Google.AR.Core.HitResult",
					"com/google/ar/core/ImageFormat:Google.AR.Core.ImageFormat",
					"com/google/ar/core/ImageMetadata:Google.AR.Core.ImageMetadata",
					"com/google/ar/core/InstallActivity:Google.AR.Core.InstallActivity",
					"com/google/ar/core/LightEstimate:Google.AR.Core.LightEstimate",
					"com/google/ar/core/LightEstimate$State:Google.AR.Core.LightEstimate/State",
					"com/google/ar/core/Plane:Google.AR.Core.Plane",
					"com/google/ar/core/Plane$Type:Google.AR.Core.Plane/Type",
					"com/google/ar/core/Point:Google.AR.Core.Point",
					"com/google/ar/core/Point$OrientationMode:Google.AR.Core.Point/OrientationMode",
					"com/google/ar/core/PointCloud:Google.AR.Core.PointCloud",
					"com/google/ar/core/Pose:Google.AR.Core.Pose",
					"com/google/ar/core/Session:Google.AR.Core.Session",
					"com/google/ar/core/Session$Feature:Google.AR.Core.Session/Feature",
					"com/google/ar/core/SharedCamera:Google.AR.Core.SharedCamera",
					"com/google/ar/core/TrackableBase:Google.AR.Core.TrackableBase",
					"com/google/ar/core/TrackingFailureReason:Google.AR.Core.TrackingFailureReason",
					"com/google/ar/core/TrackingState:Google.AR.Core.TrackingState",
				};
			}

			return Lookup (package_com_google_ar_core_mappings, klass);
		}

		static string[] package_com_google_ar_core_exceptions_mappings;
		static Type lookup_com_google_ar_core_exceptions_package (string klass)
		{
			if (package_com_google_ar_core_exceptions_mappings == null) {
				package_com_google_ar_core_exceptions_mappings = new string[]{
					"com/google/ar/core/exceptions/AnchorNotSupportedForHostingException:Google.AR.Core.Exceptions.AnchorNotSupportedForHostingException",
					"com/google/ar/core/exceptions/CameraNotAvailableException:Google.AR.Core.Exceptions.CameraNotAvailableException",
					"com/google/ar/core/exceptions/CloudAnchorsNotConfiguredException:Google.AR.Core.Exceptions.CloudAnchorsNotConfiguredException",
					"com/google/ar/core/exceptions/DataInvalidFormatException:Google.AR.Core.Exceptions.DataInvalidFormatException",
					"com/google/ar/core/exceptions/DataUnsupportedVersionException:Google.AR.Core.Exceptions.DataUnsupportedVersionException",
					"com/google/ar/core/exceptions/DeadlineExceededException:Google.AR.Core.Exceptions.DeadlineExceededException",
					"com/google/ar/core/exceptions/FatalException:Google.AR.Core.Exceptions.FatalException",
					"com/google/ar/core/exceptions/ImageInsufficientQualityException:Google.AR.Core.Exceptions.ImageInsufficientQualityException",
					"com/google/ar/core/exceptions/MissingGlContextException:Google.AR.Core.Exceptions.MissingGlContextException",
					"com/google/ar/core/exceptions/NotTrackingException:Google.AR.Core.Exceptions.NotTrackingException",
					"com/google/ar/core/exceptions/NotYetAvailableException:Google.AR.Core.Exceptions.NotYetAvailableException",
					"com/google/ar/core/exceptions/ResourceExhaustedException:Google.AR.Core.Exceptions.ResourceExhaustedException",
					"com/google/ar/core/exceptions/SessionNotPausedException:Google.AR.Core.Exceptions.SessionNotPausedException",
					"com/google/ar/core/exceptions/SessionPausedException:Google.AR.Core.Exceptions.SessionPausedException",
					"com/google/ar/core/exceptions/TextureNotSetException:Google.AR.Core.Exceptions.TextureNotSetException",
					"com/google/ar/core/exceptions/UnavailableApkTooOldException:Google.AR.Core.Exceptions.UnavailableApkTooOldException",
					"com/google/ar/core/exceptions/UnavailableArcoreNotInstalledException:Google.AR.Core.Exceptions.UnavailableArcoreNotInstalledException",
					"com/google/ar/core/exceptions/UnavailableDeviceNotCompatibleException:Google.AR.Core.Exceptions.UnavailableDeviceNotCompatibleException",
					"com/google/ar/core/exceptions/UnavailableException:Google.AR.Core.Exceptions.UnavailableException",
					"com/google/ar/core/exceptions/UnavailableSdkTooOldException:Google.AR.Core.Exceptions.UnavailableSdkTooOldException",
					"com/google/ar/core/exceptions/UnavailableUserDeclinedInstallationException:Google.AR.Core.Exceptions.UnavailableUserDeclinedInstallationException",
					"com/google/ar/core/exceptions/UnsupportedConfigurationException:Google.AR.Core.Exceptions.UnsupportedConfigurationException",
				};
			}

			return Lookup (package_com_google_ar_core_exceptions_mappings, klass);
		}

		static string[] package_com_google_vr_dynamite_client_mappings;
		static Type lookup_com_google_vr_dynamite_client_package (string klass)
		{
			if (package_com_google_vr_dynamite_client_mappings == null) {
				package_com_google_vr_dynamite_client_mappings = new string[]{
					"com/google/vr/dynamite/client/DynamiteClient:Google.VR.Dynamite.Client.DynamiteClient",
					"com/google/vr/dynamite/client/ObjectWrapper:Google.VR.Dynamite.Client.ObjectWrapper",
				};
			}

			return Lookup (package_com_google_vr_dynamite_client_mappings, klass);
		}
	}
}
