using Android.Content;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.Droid.Views;
using System;
using System.Collections.Generic;
using System.Text;
using TipCalc.Core;

namespace TipCalc.UI.Droid
{
	public class Setup : MvxAndroidSetup
	{
		public Setup(Context applicationContext)
			: base(applicationContext)
		{
		}
		protected override Cirrious.MvvmCross.ViewModels.IMvxApplication CreateApp()
		{
			return new App();
		}
	}
}
