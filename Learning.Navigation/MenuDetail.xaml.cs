using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Learning.Navigation
{
	public partial class MenuDetail : ContentPage
	{
		public string MyName
		{
			get;
			set;
		}


		public MenuDetail()
		{
			InitializeComponent();


		}

		public MenuDetail(string name)
		{
			InitializeComponent();

			lblName.Text = name;
		}
	}
}
