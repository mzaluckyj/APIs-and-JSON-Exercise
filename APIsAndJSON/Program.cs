using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {

            //exercise 1

            Console.WriteLine("Exercise 1");

            for(int x =0; x< 5; x++)
            {
                RonVSKanyeAPI.KWQoute();
                RonVSKanyeAPI.RSQoute();
            }

            //exercise 2
            Console.WriteLine("Exercise 2");

            string Key = File.ReadAllText("appsettings.json");
            string APIKey = JObject.Parse(Key).GetValue("APIKey").ToString();

            Console.WriteLine("Please eneter your Zipcode");
            var zipCode = Console.ReadLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIKey}";
            Console.WriteLine("");

            Console.WriteLine($"It is currently {OpenWeatherMapAPI.GetTemp(apiCall)} degrees F in your location");

            
        }
    }
}
