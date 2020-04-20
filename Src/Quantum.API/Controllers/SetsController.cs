using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quantum.API.Infrastructure;
using Quantum.Application.DataTransferObjects.Sets;
using Quantum.Application.Services.Contracts;
using System;
using System.Threading.Tasks;

namespace Quantum.API.Controllers
{
    /// <summary>
    /// Controller to work with word sets.
    /// </summary>
    [Route("api/sets")]
    public class SetsController : Controller
    {
        private readonly ISetsSetvice _setsSetvice;

        /// <summary>
        /// Initializes controllers with providers.
        /// </summary>
        /// <param name="setsSetvice">The instance of <see cref="ISetsSetvice"></see>.</param>
        public SetsController(ISetsSetvice setsSetvice)
        {
            _setsSetvice = setsSetvice ?? throw new ArgumentNullException(nameof(setsSetvice));
        }

        /// <summary>
        /// Creates word set.
        /// </summary>
        /// <param name="model">Word set model.</param>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpPost]
        [Validation]
        public async Task<IActionResult> CreateSet([FromBody]CreateSetModel model)
        { 
            await _setsSetvice.CreateAsync(model);
            return Ok();
        }

        /// <summary>
        /// Deletes word set.
        /// </summary>
        /// <param name="id">Word set identifier.</param>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteSet(int id)
        {
            await _setsSetvice.DeleteAsync(id);
            return Ok();
        }

        /// <summary>
        /// Updates word set.
        /// </summary>
        /// <param name="id">Word set identifier.</param>
        /// <param name="model">Word set model to update.</param>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("{id}")]
        [HttpPut]
        [Validation]
        public async Task<IActionResult> UpdateSet(int id, [FromBody]UpdateSetModel model)
        {
            await _setsSetvice.UpdateAsync(id, model);
            return Ok();
        }

        /// <summary>
        /// Returns word sets list.
        /// </summary>
        /// <returns>The collection of <see cref="WordSetModel"></see>.</returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public async Task<IActionResult> GetSets()
        {
            var result = await _setsSetvice.GetAsync();
            return Ok(result);
        }

        /// <summary>
        /// Returns word set.
        /// </summary>
        /// <param name="id">Word set identifier.</param>
        /// <returns>The instance of <see cref="WordSetModel"></see>.</returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("{id}")]
        [HttpGet]
        public async Task<IActionResult> GetSet(int id)
        {
            var result = await _setsSetvice.GetAsync(id);
            return Ok(result);
        }
    }
}
