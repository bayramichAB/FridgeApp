using FridgeApp_API.Models;


namespace FridgeApp_API.ServiceContracts
{
    public interface IFridge_ModelService
    {
        Task<IEnumerable<Fridge_Model>> GetAllModelsAsync(bool trackChanges);
        Task<Fridge_Model> GetModelByIdAsync(Guid fridgeModelid, bool trachChanges);
        Task<Fridge_Model> CreateFridgeModelAsync(Fridge_Model fridgeModel);
        Task UpdateFridgeModelAsync(Guid id, Fridge_Model fridgeModel, bool trachChanges);
        Task DeleteFridgeModelAsync(Guid id, bool trachChanges);
    }
}
