using ChuckSwapi.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChuckSwapi.Components.Interfaces
{
    public interface ISwapiLogic
    {
        Task<List<Person>> GetAllPeople();
    }
}
