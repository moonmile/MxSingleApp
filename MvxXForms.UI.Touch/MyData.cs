using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MvxXForms.UI.Touch
{
	/// <summary>
	/// DetailView に渡すデータ構造
	/// </summary>
	public class MyData
	{
		public int PageNum { get; set; }
		public string Name { get; set; }
	}
}