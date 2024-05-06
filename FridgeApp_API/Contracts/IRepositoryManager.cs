namespace FridgeApp_API.Contracts
{
    public interface IRepositoryManager
    { 
        IFridge Fridge { get; }
        IFridge_Model Fridge_Model { get; }
        IFridge_Product Fridge_Product { get; }
        IProduct Product { get; }
        Task SaveAsync();
    }
}
