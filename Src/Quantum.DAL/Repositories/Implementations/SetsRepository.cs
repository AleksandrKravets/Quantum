using Quantum.Application.Contracts.Repositories;
using Quantum.Application.DataTransferObjects.Sets;
using Quantum.DAL.Infrastructure;
using Quantum.DAL.StoredProcedures.Sets;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Quantum.DAL.Repositories.Implementations
{
    internal class SetsRepository : ISetsRepository
    {
        private readonly StoredProcedureExecutor _procedureExecutor;

        public SetsRepository(StoredProcedureExecutor procedureExecutor)
        {
            _procedureExecutor = procedureExecutor ?? throw new ArgumentNullException(nameof(procedureExecutor));
        }

        public Task CreateAsync(CreateSetModel model)
        {
            return _procedureExecutor.ExecuteAsync(new SPCreateCardSet 
            { 
                Name = model.Name 
            });
        }

        public Task DeleteAsync(int id)
        {
            return _procedureExecutor.ExecuteAsync(new SPDeleteCardSet
            {
                Id = id
            });
        }

        public Task<CardSetModel> GetAsync(int id)
        {
            return _procedureExecutor.ExecuteWithObjectResponseAsync<CardSetModel>(new SPGetSetById
            {
                Id = id
            });
        }

        public Task<ICollection<CardSetModel>> GetAsync()
        {
            return _procedureExecutor.ExecuteWithListResponseAsync<CardSetModel>(new SPGetSets());
        }

        public Task UpdateAsync(int id, UpdateSetModel model)
        {
            return _procedureExecutor.ExecuteAsync(new SPUpdateSet
            {
                Id = id, 
                Name = model.Name
            });
        }
    }
}
