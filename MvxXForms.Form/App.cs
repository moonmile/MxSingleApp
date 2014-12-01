using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MvxXForms.Form
{
	public class App
	{
		public static Page GetMainPage()
		{
			return new ContentPage
			{
				Content = new Label
				{
					Text = "Hello, Forms !",
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
				},
			};
		}

		public static Page GetDetailPage()
		{
			return new DetailXFPage();
		}
	}
}
