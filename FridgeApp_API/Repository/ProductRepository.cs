using FridgeApp_API.Contracts;
using FridgeApp_API.Data;
using FridgeApp_API.Models;

namespace FridgeApp_API.Repository
{
    public class ProductRepository :RepositoryBase<Product>,IProduct
    {
        public ProductRepository(ApiDbContext context): base(context) { }

    }
}
