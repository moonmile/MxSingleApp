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

namespace ValueConv.Touch
{
	[Register ("ValueConvTouchViewController")]
	partial class ValueConvTouchViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel textDate { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField textName { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel textTotal { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (textDate != null) {
				textDate.Dispose ();
				textDate = null;
			}
			if (textName != null) {
				textName.Dispose ();
				textName = null;
			}
			if (textTotal != null) {
				textTotal.Dispose ();
				textTotal = null;
			}
		}
	}
}
