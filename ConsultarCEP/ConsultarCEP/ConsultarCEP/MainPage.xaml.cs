using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ConsultarCEP.Services.Model;
using ConsultarCEP.Services;

namespace ConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Button.Clicked += FindCEP;
        }

        private void FindCEP(object sender, EventArgs args)
        {
            //Lógica do programa


            //Validações
            string cep = CEP.Text.Trim();

            if (isValidCEP(cep))
                try
                {
                    Addresss adr = ViaCEPServices.SearchAddressCEP(cep);
                    if (adr != null)
                    {
                        Result.Text = string.Format("Endereço: {2} de {3} {0},{1} ", adr.localidade, adr.uf, adr.logradouro, adr.bairro);
                    }
                    else
                    {
                        DisplayAlert("ERRO", "O endereço não foi encontrado para o CEP informado " + cep, "OK");
                    }
                }
                catch (Exception e)
                {
                    DisplayAlert("Erro crítico", e.Message, "OK");
                }
        }

        private bool isValidCEP(string cep)
        {
            bool valid = true;
            //if (cep.Length != 8)
            //{
            //    //erro
            //    DisplayAlert("Erro", "CEP Inválido! O CEP deve conter 8 caracteres", "OK");

            //    valid = false;
            //}
            int newCEP = 0;
            if (!int.TryParse(cep, out newCEP))
            {
                //Erro
                DisplayAlert("Erro", "CEP Inválido! O CEP deve ser composto por números", "OK");

                valid = false;

            }
            return valid;
        }
    }
}
