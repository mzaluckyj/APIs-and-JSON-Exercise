using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        public static void KWQoute()
        {
            var client = new HttpClient();

            var KWURL = "https://api.kanye.rest/";

            var KWResponse = client.GetStringAsync(KWURL).Result;

            var KWestQuote = JObject.Parse(KWResponse).GetValue("quote").ToString();

            Console.WriteLine($"Kanye:   {KWestQuote}");
            Console.WriteLine("");

        }

        public static void RSQoute()
        {
            var client = new HttpClient();

            var RSURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var RSResponse = client.GetStringAsync(RSURL).Result;

            var RonSQuote = JArray.Parse(RSResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();


            Console.WriteLine($"Ron:   {RonSQuote}");
            Console.WriteLine("");
        }

    }
}
