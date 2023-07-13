using AutoMapper;
using BookAPI.Repository;
using WebEndpoint.Data;
using WebEndpoint.Domain.Contracts;
using WebEndpoint.Endpoints.CatalogEndpoints.CatalogResult;
using WebEndpoint.Service.Contracts;

namespace WebEndpoint.Service
{
    public class BookCatalogService : ICatalog<Book, BookResult>
    {
        public string _idCatalog { get; }
        private readonly IBookRepository _repository;
        //private readonly ILogger<BookCatalogService> _logger;
        //private readonly IMapper _mapper;

        public BookCatalogService(IBookRepository repository /*, IMapper mapper,*/ /*ILogger<BookCatalogService> logger*/)
        {
            _idCatalog = Guid.NewGuid().ToString();
            _repository = repository;
            //_mapper = mapper;
            //_logger = logger;
        }
        public async Task<List<Book>> ReturnCatalogEntityAsync()
        {
            var buff = await _repository.GetAllAsync();
            ///*var res = _mapper.Map<List<Book>, List<BookResult>>(buff*/);
            return buff;
        }
    }
}
