using Quantum.Application.Contracts.Repositories;
using Quantum.Application.DataTransferObjects.Cards;
using Quantum.Application.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Quantum.Application.Services.Implementations
{
    public class CardsService : ICardsService
    {
        private readonly ICardsRepository _cardsRepository;

        public CardsService(ICardsRepository cardsRepository)
        {
            _cardsRepository = cardsRepository ?? throw new ArgumentNullException(nameof(cardsRepository));
        }

        public Task CreateAsync(CreateCardModel model)
        {
            return _cardsRepository.CreateAsync(model);
        }

        public Task DeleteAsync(int id)
        {
            return _cardsRepository.DeleteAsync(id);
        }

        public Task<ICollection<CardModel>> GetAllAsync(int setId)
        {
            return _cardsRepository.GetAllAsync(setId);
        }

        public Task<CardModel> GetAsync(int id)
        {
            return _cardsRepository.GetAsync(id);
        }

        public Task UpdateAsync(int id, UpdateCardModel model)
        {
            return _cardsRepository.UpdateAsync(id, model);
        }
    }
}
