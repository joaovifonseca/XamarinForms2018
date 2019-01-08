using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App01_ConsultarCEP.Services.Model;
using Newtonsoft.Json;

namespace App01_ConsultarCEP.Services
{
    public class ViaCEPService
    {
        public static string AddressURL = "https://viacep.com.br/ws/[0]/json/";

        public static Address SearchAddressCEP(string CEP)
        {
            //Setando o endereço do WebService
            string NewAddressURL = string.Format(AddressURL, CEP);

            //Fazendo a conexão com o WebService que retorna JSON
            WebClient wc = new WebClient();
            string Content = wc.DownloadString(NewAddressURL);

            Address adr = JsonConvert.DeserializeObject<Address>(Content);

            return adr;
        }
    }
}
