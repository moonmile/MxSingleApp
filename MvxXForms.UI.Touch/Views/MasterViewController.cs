using System;
using System.Drawing;
using System.Collections.Generic;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Xamarin.Forms;
using MvxXForms.Core.ViewModels;

namespace MvxXForms.UI.Touch
{
	public partial class MasterViewController : UITableViewController
	{
		// DataSource dataSource;

		public MasterViewController(IntPtr handle)
			: base(handle)
		{
			Title = NSBundle.MainBundle.LocalizedString("Master", "Master");
			// Custom initialization
		}

		/// <summary>
		/// 行をクリックしたとき
		/// </summary>
		/// <param name="tableView"></param>
		/// <param name="indexPath"></param>
		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			var data = new MyData();
			switch ( indexPath.Row )
			{
				case 0:
					/// MVVM を使わずに Xamarin.iOS + storyboard だけ使うパターン
					/// あらかじめ storyboard segue でつなげておく
					data.PageNum = 1;
					data.Name = "Xamarin.iOS only";
					break;
				case 1:
					/// MvvmCross を使って vm 経由でデータを渡す
					/// 本来は data 経由のほうがいいけど、これはサンプルで
					/// あらかじめ storyboard segue でつなげておく
					_datavm = new TipViewModel()
					{
						PageNum = 2,
						Name = "use MvvmCross"
					};
					break;
				case 2:
                    /// storyboard のページを直接開く 
					/// Storyboard ID を ViewController に設定しておく
					/// storyboard segue を使わないパターン
					var vc = (Detail3ViewController)Storyboard.InstantiateViewController("Detail3ViewController");
					this.NavigationController.ShowViewController(vc, this);
					_datavm2 = new TipViewModel2()
					{
						PageNum = 3,
						Name = "Mvx + direct storyboard"
					};
					break;
				case 3:
					// Xamarin.Forms ページを開く
					var page = MvxXForms.Form.App.GetDetailPage();
					var vc2 = page.CreateViewController();
					var vm = new TipViewModel()
					{
						PageNum = 4,
						Name = "xamarin froms page"
					};
					page.BindingContext = vm;
					this.NavigationController.ShowViewController(vc2, this);
					break;

			}
			_data = data;
		}
		public static MyData _data;
		public static TipViewModel _datavm;
		public static TipViewModel2 _datavm2;
	}
}
