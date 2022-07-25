using ChuckSwapi.Brokers.Interfaces;
using ChuckSwapi.Components.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChuckSwapi.Components
{
    public class ChuckLogic : IChuckLogic
    {
        private readonly IChuckBroker _chuckBroker;
        public ChuckLogic(IChuckBroker chuckBroker)
        {
            _chuckBroker = chuckBroker;
        }
        public async Task<List<string>> GetAllCategories()
        {
            return await _chuckBroker.GetAllCategories();
        }
    }
}
