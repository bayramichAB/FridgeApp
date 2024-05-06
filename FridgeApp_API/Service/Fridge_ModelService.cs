using AutoMapper;
using FridgeApp_API.Contracts;
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


    }
}
