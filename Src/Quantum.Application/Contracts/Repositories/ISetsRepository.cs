using Quantum.Application.DataTransferObjects.Sets;
using System.Threading.Tasks;

namespace Quantum.Application.Contracts.Repositories
{
    public interface ISetsRepository
    {
        Task CreateAsync(CreateSetModel model);
    }
}
