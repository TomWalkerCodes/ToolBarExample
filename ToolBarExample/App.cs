using System;
using Xamarin.Forms;

namespace ToolBarExample
{
	public class App
	{
		public static int CurrentPageCount {
			get;
			set;
		}
		public static Page GetMainPage ()
		{	
			return new NavigationPage (new MainPage ());
		}
	}
}

