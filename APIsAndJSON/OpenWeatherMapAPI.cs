using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;
using System.Net.Http;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {

        public static double GetTemp(string apiCall)
        {
            var client = new HttpClient();

            var repsone = client.GetStringAsync(apiCall).Result;

            var temp = double.Parse(JObject.Parse(repsone)["main"]["temp"].ToString());

            return temp;

        }
    }
}
