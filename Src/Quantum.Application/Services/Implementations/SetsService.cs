using Quantum.Application.Contracts.Repositories;
using Quantum.Application.DataTransferObjects.Sets;
using Quantum.Application.Services.Contracts;
using System;
using System.Collections.Generic;
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

        public Task DeleteAsync(int id)
        {
            return _setsRepository.DeleteAsync(id);
        }

        public Task<CardSetModel> GetAsync(int id)
        {
            return _setsRepository.GetAsync(id);
        }

        public Task<ICollection<CardSetModel>> GetAllAsync()
        {
            return _setsRepository.GetAsync();
        }

        public Task UpdateAsync(int id, UpdateSetModel model)
        {
            return _setsRepository.UpdateAsync(id, model);
        }
    }
}
