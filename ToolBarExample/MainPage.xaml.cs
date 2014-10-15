using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ToolBarExample
{	
	public partial class MainPage : ContentPage
	{	
		public MainPage ()
		{
			InitializeComponent ();
		}

		private void GotoFirstPage_Clicked(object sender, EventArgs e)
		{
			App.CurrentPageCount = 1;
			var page = new MyPage();
			Navigation.PushAsync(page);
		}
	}
}

