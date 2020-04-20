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
            return _procedureExecutor.ExecuteAsync(new SPCreateWordSet 
            { 
                SetName = model.Name 
            });
        }

        public Task DeleteAsync(int id)
        {
            return _procedureExecutor.ExecuteAsync(new SPDeleteWordSet
            {
                Id = id
            });
        }

        public Task<WordSetModel> GetAsync(int id)
        {
            return _procedureExecutor.ExecuteWithObjectResponseAsync<WordSetModel>(new SPGetSetById
            {
                Id = id
            });
        }

        public Task<ICollection<WordSetModel>> GetAsync()
        {
            return _procedureExecutor.ExecuteWithListResponseAsync<WordSetModel>(new SPGetSets());
        }

        public Task UpdateAsync(int id, UpdateSetModel model)
        {
            return _procedureExecutor.ExecuteAsync(new SPUpdateSet
            {
                Id = id
            });
        }
    }
}
