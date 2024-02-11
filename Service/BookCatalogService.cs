using AutoMapper;
using BookAPI.Repository;
using WebEndpoint.Data.Entity;
using WebEndpoint.Endpoints.CatalogEndpoints.CatalogResult;
using WebEndpoint.Service.Contracts;

namespace WebEndpoint.Service
{
    public class BookCatalogService : ICatalog<Book, BookResult>
    {
        public string _idCatalog { get; }
        private readonly IBookRepository _repository;
        private readonly IMapper _mapper;

        public BookCatalogService(IBookRepository repository, IMapper mapper)
        {
            _idCatalog = Guid.NewGuid().ToString();
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<BookResult>> ReturnCatalogEntityAsync()
        {
            var buff = await _repository.GetAllAsync();
            var res = _mapper.Map<List<BookResult>>(buff);
            return res;
        }
    }
}