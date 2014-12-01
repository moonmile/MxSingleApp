using System;
using System.Drawing;
using System.Collections.Generic;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MvxXForms.UI.Touch
{
	public partial class DetailViewController : UIViewController
	{
		public DetailViewController(IntPtr handle)
			: base(handle)
		{
		}

		public override void DidReceiveMemoryWarning()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning();

			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Perform any additional setup after loading the view, typically from a nib.
			var data = MasterViewController._data;
			this.labelPageNum.Text = data.PageNum.ToString();
			this.labelName.Text = data.Name;
		}
	}
}
