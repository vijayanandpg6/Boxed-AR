using System;

namespace Google.AR.Core.Annotations {

	[global::Android.Runtime.Annotation ("com.google.ar.core.annotations.NativeEnum")]
	public partial class NativeEnumAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
