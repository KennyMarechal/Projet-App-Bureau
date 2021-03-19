using IdentityModel.Client;
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
        public List<Convert> GetConvert()
        {
            var client = new RestClient("https://currency-converter5.p.rapidapi.com/currency/convert?format=json&from=CAD&to=EUR&amount=100");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "currency-converter5.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "9c57daa3b6msha895a7ced513f57p10e8adjsn81efbbae234a");
            IRestResponse response = client.Execute(request);

            dynamic array = JsonConvert.DeserializeObject(response.Content);

            List<Convert> t_Convert = new List<Convert>();

            Convert t_devise = new Convert();

            t_devise.amount = array.amount;
            t_devise.rate = array.rates.EUR.rate;
            t_devise.rate_for_amount = array.rates.EUR.rate_for_amount;

            t_Convert.Add(t_devise);
          
            return t_Convert;
        }
        
    }
}
