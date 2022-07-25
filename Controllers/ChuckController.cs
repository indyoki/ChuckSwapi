using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using ChuckSwapi.Components.Interfaces;
using System.Linq;

namespace ChuckSwapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChuckController : ControllerBase
    {
        private readonly ILogger<ChuckController> _logger;
        private readonly IChuckLogic _chuckLogic;
        public ChuckController(ILogger<ChuckController> logger, IChuckLogic chuckLogic)
        {
            _chuckLogic = chuckLogic;
            _logger = logger;
        }
        [HttpGet("categories")]
        public async Task<ActionResult<List<string>>> GetAllCategories()
        {
            try
            {
                var result = await _chuckLogic.GetAllCategories();
                if (result == null || !result.Any())
                    return NotFound();
                
                return Ok(result);
            }
            catch(Exception ex)
            {
                _logger.LogError("An error occured while attempting to retrieve joke categories. Exception: @ex ", ex);
                throw;
            }
        }
    }
}
