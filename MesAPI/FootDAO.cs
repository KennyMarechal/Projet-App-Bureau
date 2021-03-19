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
    public class FootDAO
    {
        public List<Foot> GetMatchs()
        {
            var client = new RestClient("https://free-football-soccer-videos.p.rapidapi.com/");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "free-football-soccer-videos.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "9c57daa3b6msha895a7ced513f57p10e8adjsn81efbbae234a");
            IRestResponse response = client.Execute(request);

            dynamic array = JsonConvert.DeserializeObject(response.Content);

            List<Foot> t_Foot = new List<Foot>();

            foreach (var x in array)
            {
                Foot t_Match = new Foot();

                t_Match.title = x.title;
                t_Match.url = x.url;
                t_Match.date = x.date;
                t_Match.nameCompetition = x.competition.name;

                t_Foot.Add(t_Match);
            }

            return t_Foot;
        }
    }
}
