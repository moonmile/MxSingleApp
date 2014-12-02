// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace MvxVB.Touch
{
	[Register ("TouchViewController")]
	partial class TouchViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelTip { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISlider sliderGene { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField textSubTotal { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (labelTip != null) {
				labelTip.Dispose ();
				labelTip = null;
			}
			if (sliderGene != null) {
				sliderGene.Dispose ();
				sliderGene = null;
			}
			if (textSubTotal != null) {
				textSubTotal.Dispose ();
				textSubTotal = null;
			}
		}
	}
}
