using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChuckSwapi.Brokers.Interfaces
{
    public interface IChuckBroker
    {
        Task<List<string>> GetAllCategories();
    }
}
