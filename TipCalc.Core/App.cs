﻿using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using TipCalc.Core.Services;
using TipCalc.Core.ViewModels;

namespace TipCalc.Core
{
	public class App : MvxApplication
	{
	public App()
	{
		// Mvx.RegisterType<ICalculation, Calculation>();
		// Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<TipViewModel>());
	}
	}
}
