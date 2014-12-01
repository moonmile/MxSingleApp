using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using System;
using System.Collections.Generic;
using System.Text;
using ValueConv.Core;

namespace ValueConv.Touch
{
public class Setup : MvxTouchSetup
{
	public Setup(MvxApplicationDelegate appDelegate, IMvxTouchViewPresenter presenter)
		: base(appDelegate, presenter)
	{
	}

	protected override Cirrious.MvvmCross.ViewModels.IMvxApplication CreateApp()
	{
		return new App();
	}
}
}
