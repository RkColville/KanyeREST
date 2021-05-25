using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeREST
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            for (int i = 0; i < 1; i++)
            {
                do
                {
                    Quotes.KanyeQuote();
                    Quotes.RonQuote();
                    i++;
                } while (i <= 4);
            }
            
            


        }
    }
}
