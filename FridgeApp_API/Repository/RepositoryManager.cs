using FridgeApp_API.Contracts;
using FridgeApp_API.Data;

namespace FridgeApp_API.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly ApiDbContext _context;
        private readonly Lazy<IFridge> _fridgeRepo;
        private readonly Lazy<IFridge_Model> _fridge_ModelRepo;
        private readonly Lazy<IFridge_Product> _fridge_ProductRepo;
        private readonly Lazy<IProduct> _productRepo;

        public RepositoryManager(ApiDbContext context)
        {
            _context = context;
            _fridgeRepo = new Lazy<IFridge>(() => new FridgeRepository(context));
            _fridge_ModelRepo = new Lazy<IFridge_Model>(() => new Fridge_ModelRepository(context));
            _fridge_ProductRepo = new Lazy<IFridge_Product>(() => new Fridge_ProductRepository(context));
            _productRepo = new Lazy<IProduct>(() => new ProductRepository(context));
        }

        public IFridge Fridge => _fridgeRepo.Value;
        public IFridge_Model Fridge_Model => _fridge_ModelRepo.Value;
        public IFridge_Product Fridge_Product => _fridge_ProductRepo.Value;
        public IProduct Product => _productRepo.Value;
        public async Task SaveAsync() => await _context.SaveChangesAsync();
    }
}
