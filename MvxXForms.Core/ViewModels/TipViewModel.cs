using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvxXForms.Core.ViewModels
{
	public class TipViewModel : MvxViewModel
	{
		public TipViewModel()
		{
		}

		int _pageNum;
		public int PageNum
		{
			get { return _pageNum; }
			set { _pageNum = value; RaisePropertyChanged(() => PageNum); }
		}
		string _Name;
		public string Name
		{
			get { return _Name; }
			set { _Name = value; RaisePropertyChanged(() => Name); }
		}
	}
	public class TipViewModel2 : TipViewModel { }
	/*
	public class TipViewModel2 : MvxViewModel
	{
		public TipViewModel2()
		{
		}

		int _pageNum;
		public int PageNum
		{
			get { return _pageNum; }
			set { _pageNum = value; RaisePropertyChanged(() => PageNum); }
		}
		string _Name;
		public string Name
		{
			get { return _Name; }
			set { _Name = value; RaisePropertyChanged(() => Name); }
		}
	}
	*/

}

