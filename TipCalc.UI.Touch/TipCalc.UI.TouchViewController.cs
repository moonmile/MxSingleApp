using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using TipCalc.Core.ViewModels;
using Cirrious.MvvmCross.ViewModels;

namespace TipCalc.UI.Touch
{
public partial class TipCalcUITouchViewController : MvxViewController
{
	public TipCalcUITouchViewController(IntPtr handle)
		: base(handle)
	{
	}

	public new TipViewModel ViewModel
	{
		get { return (TipViewModel)base.ViewModel; }
		set { base.ViewModel = value; }
	}
		
	public override void DidReceiveMemoryWarning()
	{
		// Releases the view if it doesn't have a superview.
		base.DidReceiveMemoryWarning();

		// Release any cached data, images, etc that aren't in use.
	}

	#region View lifecycle

	public override void ViewDidLoad()
	{
		this.Request = new MvxViewModelRequest(typeof(TipViewModel), null, null, new MvxRequestedBy()); 
		base.ViewDidLoad();
		// Perform any additional setup after loading the view, typically from a nib.
		var set = this.CreateBindingSet<TipCalcUITouchViewController, TipViewModel>();
		set.Bind(labelTip).To(vm => vm.Tip);
		set.Bind(textSubTotal).To(vm => vm.SubTotal);
		set.Bind(sliderGene).To(vm => vm.Generosity);
		set.Apply();
	}

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