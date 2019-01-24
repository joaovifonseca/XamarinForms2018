using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TypePageXF.TypePage.Carousel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TypePage3 : ContentPage
	{
		public TypePage3 ()
		{
			InitializeComponent ();
		}
        private void ChangePage(object sender, EventArgs args)
        {
            //App.Current.MainPage = new NavigationPage(new Navigation.Page1()) { BarBackgroundColor= Color.Blue};
            App.Current.MainPage = new Tabbed.flaps();
        }

    }
}