using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quantum.API.Infrastructure;
using Quantum.Application.DataTransferObjects.Cards;
using Quantum.Application.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Quantum.API.Controllers
{
    /// <summary>
    /// Controller to work with cards.
    /// </summary>
    [Route("api/cards")]
    public class CardsController : Controller
    {
        private readonly ICardsService _cardsService;

        /// <summary>
        /// Initializes controller with providers.
        /// </summary>
        /// <param name="cardsService">The instance of <see cref="ICardsService"></see>.</param>
        public CardsController(ICardsService cardsService)
        {
            _cardsService = cardsService ?? throw new ArgumentNullException(nameof(cardsService));
        }

        /// <summary>
        /// Creates card.
        /// </summary>
        /// <param name="model">Card model.</param>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Validation]
        public async Task<IActionResult> CreateCard([FromBody]CreateCardModel model)
        {
            await _cardsService.CreateAsync(model);
            return Ok();
        }
        
        /// <summary>
        /// Deletes card.
        /// </summary>
        /// <param name="id">Card identifier.</param>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteCard(int id)
        {
            await _cardsService.DeleteAsync(id);
            return Ok();
        }

        /// <summary>
        /// Returns card.
        /// </summary>
        /// <param name="id">Card identifier.</param>
        /// <returns>The instance of <see cref="CardModel"></see>.</returns>
        [ProducesResponseType(typeof(CardModel), StatusCodes.Status200OK)]
        [Route("{id}")]
        [HttpGet]
        public async Task<IActionResult> GetCard(int id)
        {
            var result = await _cardsService.GetAsync(id);
            return Ok(result);
        }

        /// <summary>
        /// Return cards list.
        /// </summary>
        /// <param name="id">Card identifier.</param>
        /// <returns>The collection of <see cref="CardModel"></see>.</returns>
        [ProducesResponseType(typeof(List<CardModel>), StatusCodes.Status200OK)]
        [Route("~/api/sets/{id}/cards")]
        [HttpGet]
        public async Task<IActionResult> GetCards(int id)
        {
            var result = await _cardsService.GetAllAsync(id);
            return Ok(result);
        }

        /// <summary>
        /// Updates card.
        /// </summary>
        /// <param name="id">Card identifier.</param>
        /// <param name="model">Card model to update.</param>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("{id}")]
        [HttpPut]
        [Validation]
        public async Task<IActionResult> UpdateCard(int id, [FromBody]UpdateCardModel model)
        {
            await _cardsService.UpdateAsync(id, model);
            return Ok();
        }
    }
}
