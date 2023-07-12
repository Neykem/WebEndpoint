using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebEndpoint.Endpoints.CatalogEndpoints.CatalogResult;

namespace WebEndpoint.Endpoints.CatalogEndpoints
{
    public class GetAll 
    {
        private readonly Logger<GetAll> _logger;
        private readonly IMapper _mapper;
        public GetAll(Logger<GetAll> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }
    }
}
