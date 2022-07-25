using ChuckSwapi.Brokers.Interfaces;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ChuckSwapi.Brokers
{
    public class ChuckBroker : IChuckBroker
    {
        private readonly IConfiguration _configuration;
        public ChuckBroker(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<List<string>> GetAllCategories()
        {
            try
            {
                using var client = new HttpClient();
                List<string> categories = new List<string>();
                var response = await client.GetAsync(_configuration.GetConnectionString("ChuckEndpoint"));
                if (response.IsSuccessStatusCode)
                {
                    categories = JsonConvert.DeserializeObject<List<string>>(await response.Content.ReadAsStringAsync());
                }

                return categories;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
