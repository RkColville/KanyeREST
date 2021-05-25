using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;


namespace KanyeREST
{
    public class Quotes
    {
        public static void KanyeQuote()
        {

            //This will allow me to make a request to the internet
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest";


            //"client" is the instance of my internet object. We are using the
            //URL to get a response back.
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            //"quote" is the name of the value I want to get.
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            //for (int i = 0; i <= 5; i++)
            //{
                Console.WriteLine($"----------------");
                Console.WriteLine($"Kanye: {kanyeQuote}");
                Console.WriteLine($"----------------");
            //}
        }

        public static void RonQuote()
        {

            var client = new HttpClient();
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = client.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse).ToString().
                            Replace('[', ' ').Replace(']', ' ').Trim();

            //for (int i = 0; i <= 5; i++)
            //{
                Console.WriteLine($"----------------");
                Console.WriteLine($"Ron: {ronQuote}");
                Console.WriteLine($"----------------");
            //}

        }
    }
}
