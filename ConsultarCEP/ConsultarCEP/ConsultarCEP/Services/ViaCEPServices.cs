using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using ConsultarCEP.Services.Model;
using System.Net;

namespace ConsultarCEP.Services
{
    class ViaCEPServices
    {
        public static string AddressURL = "https://viacep.com.br/ws/{0}/json/";

        public static Addresss SearchAddressCEP(string CEP)
        {
            //Setando o endereço do WebService
            string NewAddressURL = string.Format(AddressURL, CEP);

            //Fazendo a conexão com o WebService que retorna JSON
            WebClient wc = new WebClient();
            string Content = wc.DownloadString(NewAddressURL);

            Addresss adr = JsonConvert.DeserializeObject<Addresss>(Content);

            if (adr.cep == null) return null;

            return adr;
        }
    }
}
