using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using TipCalc.Core.ViewModels;
using Cirrious.MvvmCross.ViewModels;

namespace TipCalc.UI.Droid
{
	[Activity(Label = "TipCalc.UI.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : MvxActivity
	{
		public new TipViewModel ViewModel
		{
			get { return (TipViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}
/*
		protected override void OnViewModelSet()
		{
			base.OnViewModelSet();
			SetContentView(Resource.Layout.Main);
		}
*/
		protected override void OnCreate(Bundle bundle)
		{
            base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			var textSubTotal = FindViewById<EditText>(Resource.Id.textSubTotal);
			var sliderGene = FindViewById<SeekBar>(Resource.Id.sliderGene);
			var labelTip = FindViewById<TextView>(Resource.Id.labelTip);

			var set = this.CreateBindingSet<MainActivity, TipViewModel>();
			set.Bind(labelTip).To(vm => vm.Tip);
			set.Bind(textSubTotal).To(vm => vm.SubTotal);
			set.Bind(sliderGene).To(vm => vm.Generosity);
			set.Apply();
		}
	}
}

