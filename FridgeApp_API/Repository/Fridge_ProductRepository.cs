using FridgeApp_API.Contracts;
using FridgeApp_API.Data;
using FridgeApp_API.Models;

namespace FridgeApp_API.Repository
{
    public class Fridge_ProductRepository : RepositoryBase<Fridge_Product>, IFridge_Product
    {
        public Fridge_ProductRepository(ApiDbContext context):base(context) { }

    }
}
