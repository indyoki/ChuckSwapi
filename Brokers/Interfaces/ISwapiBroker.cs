using ChuckSwapi.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChuckSwapi.Brokers.Interfaces
{
    public interface ISwapiBroker
    {
        Task<List<Person>> GetAllPeople();
    }
}
