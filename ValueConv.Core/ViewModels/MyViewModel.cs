using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ValueConv.Core.ViewModels
{
	public class MyViewModel : MvxViewModel
	{
		public MyViewModel()
		{
			_UserName = "masuda";
			_Total = 100.123;
			_Today = DateTime.Now;
		}


		private double _Total;
		public double Total
		{
			get { return _Total; }
			set { _Total = value; RaisePropertyChanged(() => Total); }
		}
		private string _UserName;
		public string UserName
		{
			get { return _UserName; }
			set { _UserName = value; RaisePropertyChanged(() => UserName); }
		}
		private DateTime _Today;
		public DateTime Today
		{
			get { return _Today; }
			set { _Today = value; RaisePropertyChanged(() => Today); }
		}
	}
}
