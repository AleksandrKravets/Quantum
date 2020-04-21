using Quantum.Application.Contracts.Repositories;
using Quantum.Application.DataTransferObjects.Cards;
using Quantum.DAL.Infrastructure;
using Quantum.DAL.StoredProcedures.Cards;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Quantum.DAL.Repositories.Implementations
{
    internal class CardsRepository : ICardsRepository
    {
        private readonly StoredProcedureExecutor _procedureExecutor;

        public CardsRepository(StoredProcedureExecutor procedureExecutor)
        {
            _procedureExecutor = procedureExecutor ?? throw new ArgumentNullException(nameof(procedureExecutor));
        }

        public Task CreateAsync(CreateCardModel model)
        {
            return _procedureExecutor.ExecuteAsync(new SPCreateCard
            {
                SetId = model.SetId,
                Word = model.Word,
                Translation = model.Translation
            });
        }

        public Task DeleteAsync(int id)
        {
            return _procedureExecutor.ExecuteAsync(new SPDeleteCard
            {
                Id = id
            });
        }

        public Task<ICollection<CardModel>> GetAllAsync(int setId)
        {
            return _procedureExecutor.ExecuteWithListResponseAsync<CardModel>(new SPGetCards
            {
                SetId = setId
            });
        }

        public Task<CardModel> GetAsync(int id)
        {
            return _procedureExecutor.ExecuteWithObjectResponseAsync<CardModel>(new SPGetCard
            {
                Id = id
            });
        }

        public Task UpdateAsync(int id, UpdateCardModel model)
        {
            return _procedureExecutor.ExecuteAsync(new SPUpdateCard
            {
                Id = id, 
                Word = model.Word, 
                Translation = model.Translation
            });
        }
    }
}
