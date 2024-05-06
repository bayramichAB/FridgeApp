using FridgeApp_API.Contracts;
using FridgeApp_API.Data;
using FridgeApp_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace FridgeApp_API.Repository
{
    public class FridgeRepository : RepositoryBase<Fridge>,IFridge
    {
        public FridgeRepository(ApiDbContext context): base(context)
        {
            
        }
        /*public async Task<IEnumerable<Fridge>> GetAllFridges(bool trackChanges) =>
            await FindAll(trackChanges).OrderBy(c => c.OwnerName).ToListAsync();*/
    }
}
