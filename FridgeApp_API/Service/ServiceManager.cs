using AutoMapper;
using FridgeApp_API.Contracts;
using FridgeApp_API.ServiceContracts;

namespace FridgeApp_API.Service
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IFridgeService> _fridgeService;
        private readonly Lazy<IFridge_ModelService> _fridgeModelService;
        private readonly Lazy<IFridge_ProductService> _fridgeProductService;
        private readonly Lazy<IProductService> _productService;

        public ServiceManager(IRepositoryManager repo,IMapper mapper)
        {
            _fridgeService = new Lazy<IFridgeService>(() => new FridgeService(repo,mapper));
            _fridgeModelService = new Lazy<IFridge_ModelService>(() => new Fridge_ModelService(repo,mapper));
            _fridgeProductService = new Lazy<IFridge_ProductService>(() => new Fridge_ProductService(repo,mapper));
            _productService = new Lazy<IProductService>(() => new ProductService(repo,mapper));
        }

        public IFridgeService FridgeService =>_fridgeService.Value;
        public IFridge_ModelService Fridge_ModelService =>_fridgeModelService.Value;
        public IFridge_ProductService Fridge_ProductService => _fridgeProductService.Value;
        public IProductService ProductService => _productService.Value;
    }
}
