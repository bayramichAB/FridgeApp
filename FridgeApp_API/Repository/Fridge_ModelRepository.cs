using FridgeApp_API.Contracts;
using FridgeApp_API.Data;
using FridgeApp_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FridgeApp_API.Repository
{
    public class Fridge_ModelRepository : RepositoryBase<Fridge_Model>,IFridge_Model
    {
        public Fridge_ModelRepository(ApiDbContext context):base(context) { }


        public async Task<IEnumerable<Fridge_Model>> GetAllModels(bool trackChanges) =>
            await FindAll(trackChanges).OrderBy(c => c.Name).ToListAsync();

#pragma warning disable CS8603
        public async Task<Fridge_Model> GetModelsById(Guid fridgeModelid, bool trachChanges) =>
           await FindByCondition(f => f.Id.Equals(fridgeModelid), trachChanges).SingleOrDefaultAsync();

        public void CreateFridgeModel(Fridge_Model fridgeModel) => Create(fridgeModel);
        public void DeleteFridgeModel(Fridge_Model fridgeModel) => Delete(fridgeModel);
    }
}
