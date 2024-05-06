using AutoMapper;
using FridgeApp_API.Contracts;
using FridgeApp_API.Models;
using FridgeApp_API.ServiceContracts;

namespace FridgeApp_API.Service
{
    public class Fridge_ModelService : IFridge_ModelService
    {
        private readonly IRepositoryManager _repo;
        private readonly IMapper _mapper;
        public Fridge_ModelService(IRepositoryManager repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Fridge_Model>> GetAllModelsAsync(bool trackChanges)
        {
            return await _repo.Fridge_Model.GetAllModels(trackChanges);
        }

        public async Task<Fridge_Model> GetModelByIdAsync(Guid fridgeModelid, bool trackChanges) =>
           await _repo.Fridge_Model.GetModelsById(fridgeModelid, trackChanges);

        public async Task<Fridge_Model> CreateFridgeModelAsync(Fridge_Model fridgeModel)
        {
            _repo.Fridge_Model.CreateFridgeModel(fridgeModel);
            await _repo.SaveAsync();
            var FridgeModelToReturn = _mapper.Map<Fridge_Model>(fridgeModel);
            return FridgeModelToReturn;
        }

        public async Task UpdateFridgeModelAsync(Guid id, Fridge_Model fridgeModel, bool trackChanges)
        {
            var fridgeModelEntity = await FridgeModelCheck(id, trackChanges);
            _mapper.Map(fridgeModel, fridgeModelEntity);
            await _repo.SaveAsync();
        }

        public async Task<Fridge_Model> FridgeModelCheck(Guid id, bool trackChanges)
        {
            var fridgeModelEntity = await _repo.Fridge_Model.GetModelsById(id, trackChanges);
            if (fridgeModelEntity is null)
            {
                return null;
            }
            return fridgeModelEntity;
        }

        public async Task DeleteFridgeModelAsync(Guid id, bool trackChanges)
        {
            var fridgeModel = await FridgeModelCheck(id, trackChanges);
            _repo.Fridge_Model.DeleteFridgeModel(fridgeModel);
            await _repo.SaveAsync();
        }
    }
}
