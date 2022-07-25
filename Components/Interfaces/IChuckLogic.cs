using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChuckSwapi.Components.Interfaces
{
    public interface IChuckLogic
    {
        Task<List<string>> GetAllCategories();
    }
}
