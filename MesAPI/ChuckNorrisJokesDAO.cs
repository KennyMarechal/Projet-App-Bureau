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
    public class ChuckNorrisJokesDAO
    {
        public List<ChuckNorrisJokesRng> GetChuckNorisJokes()
        {
            var client = new RestClient("https://matchilling-chuck-norris-jokes-v1.p.rapidapi.com/jokes/random");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "matchilling-chuck-norris-jokes-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "9c57daa3b6msha895a7ced513f57p10e8adjsn81efbbae234a");
            request.AddHeader("accept", "application/json");
            IRestResponse response = client.Execute(request);

            dynamic array = JsonConvert.DeserializeObject(response.Content);

            List<ChuckNorrisJokesRng> Blague = new List<ChuckNorrisJokesRng>();

            ChuckNorrisJokesRng t_Blague = new ChuckNorrisJokesRng();

            t_Blague.id = array.id;
            t_Blague.icon_url = array.icon_url;
            t_Blague.url = array.url;
            t_Blague.value = array.value;

            Blague.Add(t_Blague);

            return Blague;        
        }
        /*
         
         */

    }
        
}
