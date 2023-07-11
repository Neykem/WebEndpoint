using Ardalis.ApiEndpoints;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebEndpoint.Endpoints.CatalogEndpoints.CatalogResult;

namespace WebEndpoint.Endpoints.CatalogEndpoints
{
    public class GetAll : EndpointBaseAsync.WithRequest<int>
      .WithActionResult<BookResult>
    {
        private readonly Logger<GetAll> _logger;
        private readonly IMapper _mapper;
        public GetAll(Logger<GetAll> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// Get all books 
        /// </summary>
        [HttpGet("api/[namespace]/{id}", Name = "[namespace]_[controller]")]
        public override async Task<ActionResult<BookResult>> HandleAsync(int request, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
