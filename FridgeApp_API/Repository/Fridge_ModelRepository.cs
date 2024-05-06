using FridgeApp_API.Contracts;
using FridgeApp_API.Data;

namespace FridgeApp_API.Repository
{
    public class Fridge_ModelRepository : RepositoryBase<Fridge_ModelRepository>,IFridge_Model
    {
        public Fridge_ModelRepository(ApiDbContext context):base(context) { }

    }
}
