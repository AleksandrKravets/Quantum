using Quantum.Application.DataTransferObjects.Sets;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Quantum.Application.Contracts.Repositories
{
    public interface ISetsRepository
    {
        Task CreateAsync(CreateSetModel model);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, UpdateSetModel model);
        Task<CardSetModel> GetAsync(int id);
        Task<ICollection<CardSetModel>> GetAsync();
    }
}
