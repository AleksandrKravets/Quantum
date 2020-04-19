using Quantum.Application.Contracts.Repositories;
using Quantum.Application.DataTransferObjects.Sets;
using Quantum.Application.Services.Contracts;
using System;
using System.Threading.Tasks;

namespace Quantum.Application.Services.Implementations
{
    public class SetsService : ISetsSetvice
    {
        private readonly ISetsRepository _setsRepository;

        public SetsService(ISetsRepository setsRepository)
        {
            _setsRepository = setsRepository ?? throw new ArgumentNullException(nameof(setsRepository));
        }

        public Task CreateAsync(CreateSetModel model)
        {
            return _setsRepository.CreateAsync(model);
        }
    }
}
