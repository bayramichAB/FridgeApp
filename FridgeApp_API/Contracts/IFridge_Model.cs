using FridgeApp_API.Models;

namespace FridgeApp_API.Contracts
{
    public interface IFridge_Model
    {
        Task<IEnumerable<Fridge_Model>> GetAllModels(bool trackChanges);

        Task<Fridge_Model> GetModelsById(Guid fridgeModelid, bool trachChanges);
        void CreateFridgeModel(Fridge_Model fridgeModel);
        void DeleteFridgeModel(Fridge_Model fridgeModel);
    }
}
