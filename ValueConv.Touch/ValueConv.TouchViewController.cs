using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.ViewModels;
using ValueConv.Core.ViewModels;

namespace ValueConv.Touch
{
	public partial class ValueConvTouchViewController : MvxViewController
	{
		public ValueConvTouchViewController(IntPtr handle)
			: base(handle)
		{
		}

		public new MyViewModel ViewModel
		{
			get { return (MyViewModel)base.ViewModel;  }
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
			this.Request = new MvxViewModelRequest(typeof(MyViewModel), null, null, new MvxRequestedBy());
			base.ViewDidLoad();

			// Perform any additional setup after loading the view, typically from a nib.
			var set = this.CreateBindingSet<ValueConvTouchViewController, MyViewModel>();
			set.Bind(textName).To(vm => vm.UserName);
			set.Bind(textTotal).To(vm => vm.Total);
			set.Bind(textDate).To(vm => vm.Today);
			set.Apply();

			this.ViewModel.UserName = "masuda";
			this.ViewModel.Total = 100;
			this.ViewModel.Today = DateTime.Now;
		}

		#region View lifecycle
		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
		}

		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);
		}

		public override void ViewWillDisappear(bool animated)
		{
			base.ViewWillDisappear(animated);
		}

		public override void ViewDidDisappear(bool animated)
		{
			base.ViewDidDisappear(animated);
		}

		#endregion
	}
}