using FridgeApp_API.Models;

namespace FridgeApp_API.ServiceContracts
{
    public interface IFridgeService
    {
        Task<IEnumerable<Fridge>> GetAllFridgesAsync(bool trackChanges);
        Task<Fridge> GetFridgeByIdAsync(Guid fridgeid, bool trachChanges);
        Task<Fridge> CreateFridgeAsync(Fridge fridge);
        Task UpdateFridgeAsync(Guid id, Fridge fridge, bool trachChanges);
        Task DeleteFridgeAsync(Guid id,bool trachChanges);
    }
}
