using Quantum.Application.DataTransferObjects.Sets;
using System.Threading.Tasks;

namespace Quantum.Application.Services.Contracts
{
    public interface ISetsSetvice
    {
        Task CreateAsync(CreateSetModel model);
    }
}
