using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ToolBarExample
{	
	public partial class MyPage : ContentPage
	{	
		public MyPage ()
		{
			InitializeComponent ();
			this.Title = string.Format ("Page# {0}", App.CurrentPageCount.ToString ());
			ToolbarItem toolbarItem = new ToolbarItem ("Next", "Icon.png", () => {
				var page = new MyPage();
				App.CurrentPageCount += 1;
				Navigation.PushAsync(page);
			}, ToolbarItemOrder.Primary);

			ToolbarItems.Add (toolbarItem);

		}
	}
}

