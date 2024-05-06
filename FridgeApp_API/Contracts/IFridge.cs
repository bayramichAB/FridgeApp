using FridgeApp_API.Models;

namespace FridgeApp_API.Contracts
{
    public interface IFridge
    {
        Task<IEnumerable<Fridge>> GetAllFridges(bool trackChanges);

        Task<Fridge> GetFridgeById(Guid fridgeid, bool trachChanges);
        void CreateFridge(Fridge fridge);
        void DeleteFridge(Fridge fridge);
    }
}
