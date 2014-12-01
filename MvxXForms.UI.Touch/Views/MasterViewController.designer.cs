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

namespace MvxXForms.UI.Touch
{
	[Register ("MasterViewController")]
	partial class MasterViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel cel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableViewCell cell1 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableViewCell cell2 { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (cel != null) {
				cel.Dispose ();
				cel = null;
			}
			if (cell1 != null) {
				cell1.Dispose ();
				cell1 = null;
			}
			if (cell2 != null) {
				cell2.Dispose ();
				cell2 = null;
			}
		}
	}
}
