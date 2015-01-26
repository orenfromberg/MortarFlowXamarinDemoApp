using System;

namespace Flow {

	[global::Android.Runtime.Annotation ("flow.Layout")]
	public partial class LayoutAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public int Value { get; set; }

	}
}
