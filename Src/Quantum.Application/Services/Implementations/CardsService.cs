using Quantum.Application.DataTransferObjects.Cards;
using Quantum.Application.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Quantum.Application.Services.Implementations
{
    public class CardsService : ICardsService
    {
        public Task CreateAsync(CreateCardModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<CardModel>> GetAllAsync(int setId)
        {
            throw new NotImplementedException();
        }

        public Task<CardModel> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, UpdateCardModel model)
        {
            throw new NotImplementedException();
        }
    }
}
