namespace FridgeApp_API.ServiceContracts
{
    public interface IServiceManager
    {
        IFridgeService FridgeService { get; }
        IFridge_ModelService Fridge_ModelService { get; }
        IFridge_ProductService Fridge_ProductService { get; }
        IProductService ProductService { get; }
    }
}
