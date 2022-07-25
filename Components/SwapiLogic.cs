using ChuckSwapi.Brokers.Interfaces;
using ChuckSwapi.Components.Interfaces;
using ChuckSwapi.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChuckSwapi.Components
{
    public class SwapiLogic : ISwapiLogic
    {
        private readonly ISwapiBroker _swapiBroker;
        public SwapiLogic(ISwapiBroker swapiBroker)
        {
            _swapiBroker = swapiBroker;
        }
        public async Task<List<Person>> GetAllPeople()
        {
            return await _swapiBroker.GetAllPeople();
        }
    }
}
