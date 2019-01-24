using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TypePageXF.TypePage.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void ChangeForPage2(object sender, EventArgs args)
        {
            //App.Current.MainPage = 
            Navigation.PushAsync(new Page2());
        }
        private void CallModal(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Modal());
        }

        private void CallMaster(object sender, EventArgs args)
        {
            //Navigation.PushModalAsync(new Master());
            App.Current.MainPage = new Master.Master();
        }
    }
}