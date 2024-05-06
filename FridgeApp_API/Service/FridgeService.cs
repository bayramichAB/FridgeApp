using AutoMapper;
using FridgeApp_API.Contracts;
using FridgeApp_API.Models;
using FridgeApp_API.ServiceContracts;
using Microsoft.AspNetCore.Mvc;

namespace FridgeApp_API.Service
{
    public sealed class FridgeService : IFridgeService
    {
        private readonly IRepositoryManager _repo;
        private readonly IMapper _mapper;

        public FridgeService(IRepositoryManager repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Fridge>> GetAllFridgesAsync(bool trackChanges)
        {
            return  await _repo.Fridge.GetAllFridges(trackChanges);
        }

        public async Task<Fridge> GetFridgeByIdAsync(Guid fridgeid, bool trackChanges) =>
            await _repo.Fridge.GetFridgeById(fridgeid, trackChanges);

        public async Task<Fridge> CreateFridgeAsync(Fridge fridge)
        {
            _repo.Fridge.CreateFridge(fridge);
            await _repo.SaveAsync();
            var FridgeToReturn = _mapper.Map<Fridge>(fridge);
            return FridgeToReturn;
        }

        public async Task UpdateFridgeAsync(Guid id, Fridge fridge ,bool trackChanges)
        {
            var fridgeEntity = await FridgeCheck(id, trackChanges);
            _mapper.Map(fridge,fridgeEntity);
            await _repo.SaveAsync();
        }

        public async Task<Fridge> FridgeCheck(Guid id, bool trackChanges)
        {
            var fridgeEntity = await _repo.Fridge.GetFridgeById(id, trackChanges);
            if (fridgeEntity is null)
            {
                return null;
            }
            return fridgeEntity;
        }

        public async Task DeleteFridgeAsync(Guid id,bool trackChanges)
        {
            var fridge = await FridgeCheck(id, trackChanges);
            _repo.Fridge.DeleteFridge(fridge);
            await _repo.SaveAsync();
        }
    }
}
