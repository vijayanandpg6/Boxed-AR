using System;

namespace Google.AR.Core.Annotations {

	[global::Android.Runtime.Annotation ("com.google.ar.core.annotations.UsedByNative")]
	public partial class UsedByNativeAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
