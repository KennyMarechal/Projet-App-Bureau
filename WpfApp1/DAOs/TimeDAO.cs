
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
    public class TimeDAO
    {
        public List<Time> GetTime()
        {
            var client = new RestClient("https://world-clock.p.rapidapi.com/json/est/now");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "world-clock.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "9c57daa3b6msha895a7ced513f57p10e8adjsn81efbbae234a");
            IRestResponse response = client.Execute(request);

            dynamic array = JsonConvert.DeserializeObject(response.Content);

            List<Time> t_Time = new List<Time>();

            Time t_Param = new Time();

            t_Param.currentDateTime = array.currentDateTime;
            t_Param.dayOfTheWeek = array.dayOfTheWeek;
            t_Param.utcOffset = array.utcOffset;

            t_Time.Add(t_Param);

            return t_Time;
        }
    }
}
