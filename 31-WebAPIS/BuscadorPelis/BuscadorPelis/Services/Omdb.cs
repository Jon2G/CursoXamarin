using BuscadorPelis.Models;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace BuscadorPelis.Services
{
    public class Omdb
    {
        private const string ApiKey = "d4b194c2";
        public async Task<Movie> Search(string title)
        {
            try
            {
                RestRequest request = new RestRequest("/", Method.Get);
                request.AddParameter("apikey", ApiKey);
                request.AddParameter("t", title);

                RestSharp.RestClient client = new RestSharp.RestClient("http://www.omdbapi.com/");
                return await client.GetAsync<Movie>(request);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return null;
        }
    }
}
