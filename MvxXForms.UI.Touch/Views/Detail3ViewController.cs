using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Binding.BindingContext;
using MvxXForms.Core.ViewModels;

namespace MvxXForms.UI.Touch
{
	public partial class Detail3ViewController : MvxViewController
	{
		public Detail3ViewController(IntPtr handle)
			: base(handle)
		{
		}

		public new TipViewModel2 ViewModel
		{
			get { return (TipViewModel2)base.ViewModel; }
			set { base.ViewModel = value; }
		}

		public override void DidReceiveMemoryWarning()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning();

			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad()
		{
			this.Request = new MvxViewModelRequest(typeof(TipViewModel2), null, null, new MvxRequestedBy());
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			var set = this.CreateBindingSet<Detail3ViewController, TipViewModel2>();
			set.Bind(labelPageNum).To(vm => vm.PageNum);
			set.Bind(labelName).To(vm => vm.Name);
			set.Apply();

			// マスターからのデータ引き渡し
			this.ViewModel = MasterViewController._datavm2;
		}
	}
}