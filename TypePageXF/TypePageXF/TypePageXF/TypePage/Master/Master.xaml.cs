using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TypePageXF.TypePage.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();

            //Detail = new Page;
		}
        private void ChangePage1(object sender, EventArgs args)
        {
            Detail = new Navigation(new Navigation.Page1());
        }
        private void ChangePage2(object sender, EventArgs args)
        {
            Detail = new Navigation.Page2();
        }
        private void ChangePage3(object sender, EventArgs args)
        {
            Detail = new Content();
        }
    }
}