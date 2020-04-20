using Quantum.Application.DataTransferObjects.Cards;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Quantum.Application.Services.Contracts
{
    public interface ICardsService
    {
        Task CreateAsync(CreateCardModel model);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, UpdateCardModel model);
        Task<CardModel> GetAsync(int id);
        Task<ICollection<CardModel>> GetAllAsync(int setId);
    }
}
