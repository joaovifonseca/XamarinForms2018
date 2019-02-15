using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : MasterDetailPage
	{
		public Menu ()
		{
			InitializeComponent ();
		}
        
        public void GoPageXamarin(object sender, EventArgs args)
        {
            Detail = new Pages.Xamarin();
            //Navigation.PushAsync(new Pages.Xamarin());
        }

        public void GoPageProfile1(object sender, EventArgs args)
        {
            Detail = new Pages.Xamarin();
            //Navigation.PushAsync(new Pages.Profile1());
        }
    }
}