using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TypePageXF.TypePage.Tabbed
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class flaps : TabbedPage
	{
		public flaps ()
		{
			InitializeComponent ();
            Children.Add(new NavigationPage(new TypePage.Navigation.Page1()) { Title = "Item 3"});
		}
	}
}