using Quantum.Application.Contracts.Repositories;
using Quantum.Application.DataTransferObjects.Sets;
using Quantum.DAL.Infrastructure;
using Quantum.DAL.StoredProcedures.Sets;
using System;
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
            return _procedureExecutor.ExecuteWithReturnValueResponseAsync(new SPCreateSet 
            { 
                SetName = model.Name 
            });
        }
    }
}
