using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsExample
{
	public partial class ContentPage2Example : ContentPage
	{
		public ContentPage2Example()
		{
			InitializeComponent();
		}

		protected void ButtonClicked(object sender, EventArgs e)
		{

			((Button)sender).Text = "Feito!";
		}

		async protected void ImageTapped(object sender, EventArgs e)
		{

			Image image = ((Image)sender);

			image.Opacity = .5;
			await Task.Delay(200);
			image.Opacity = 1;
		}
	}
}