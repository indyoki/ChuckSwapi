using ChuckSwapi.Brokers.Interfaces;
using ChuckSwapi.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ChuckSwapi.Brokers
{
    public class SwapiBroker : ISwapiBroker
    {
        private readonly IConfiguration _configuration;
        public SwapiBroker(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<List<Person>> GetAllPeople()
        {
            try
            {
                using var client = new HttpClient();
                var people = new List<Person>();
                var response = await client.GetAsync(_configuration.GetConnectionString("SwapiEndpoint"));
                if (response.IsSuccessStatusCode)
                {
                    var people1 = JsonConvert.DeserializeObject<Person>(await response.Content.ReadAsStringAsync());
                }

                return people;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
