using Microsoft.AspNetCore.Mvc;
using Quantum.Application.DataTransferObjects.Sets;
using Quantum.Application.Services.Contracts;
using System;
using System.Threading.Tasks;

namespace Quantum.API.Controllers
{
    [Route("api/sets")]
    public class SetsController : Controller
    {
        private readonly ISetsSetvice _setsSetvice;

        public SetsController(ISetsSetvice setsSetvice)
        {
            _setsSetvice = setsSetvice ?? throw new ArgumentNullException(nameof(setsSetvice));
        }

        // Add connection string configurations (common project)
        // Test custom attribute
        // Test method

        [HttpPost]
        // [BindingRequired]
        public async Task<IActionResult> CreateSet([FromBody]CreateSetModel model)
        {
            if (model == null)
                return BadRequest();
            
            await _setsSetvice.CreateAsync(model);
            return Ok();
        }
    }
}
