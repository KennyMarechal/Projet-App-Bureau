
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesAPI
{
    public class ConvertDAO
    {
        public List<ConvertMonnaie> GetConvert(string a_Input)
        {
            ConvertMonnaie t_devise = new ConvertMonnaie();

            var client = new RestClient(GetUrl(a_Input));
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "currency-converter5.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "9c57daa3b6msha895a7ced513f57p10e8adjsn81efbbae234a");
            IRestResponse response = client.Execute(request);

            dynamic array = JsonConvert.DeserializeObject(response.Content);

            List<ConvertMonnaie> t_Convert = new List<ConvertMonnaie>();

            //t_devise.amount = Amount;
            t_devise.rate = array.rates.EUR.rate;
            t_devise.rate_for_amount = array.rates.EUR.rate_for_amount;

            t_Convert.Add(t_devise);
          
            return t_Convert;
        }

        public string GetUrl(string a_Input)
        {
            string t_BaseUrlCADtEUR = "https://currency-converter5.p.rapidapi.com/currency/convert?format=json&from=CAD&to=EUR&amount=";
            string t_UrlE = t_BaseUrlCADtEUR + a_Input;

            return t_UrlE;
        }
        
    }
}
