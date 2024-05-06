using AutoMapper;
using FridgeApp_API.Contracts;
using FridgeApp_API.ServiceContracts;

namespace FridgeApp_API.Service
{
    public class ProductService  : IProductService
    {
        private readonly IRepositoryManager _repo;
        private readonly IMapper _mapper;

        public ProductService(IRepositoryManager repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
    }
}
