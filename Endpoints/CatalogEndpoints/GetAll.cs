using FastEndpoints;
using WebEndpoint.Data;
using WebEndpoint.Endpoints.CatalogEndpoints.CatalogResult;
using WebEndpoint.Service;
using WebEndpoint.Service.Contracts;

namespace WebEndpoint.Endpoints.CatalogEndpoints
{
    public class GetAll : EndpointWithoutRequest
    {
        private readonly ICatalog<Book, BookResult> _bookCatalogService;
        public GetAll(ICatalog<Book, BookResult> bookCatalogService)
        {
            _bookCatalogService = bookCatalogService;
        }

        public override void Configure()
        {
            Verbs(Http.GET);
            Routes("example");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var res = await _bookCatalogService.ReturnCatalogEntityAsync();
            if (res != null) { 
            }
            await SendAsync(res);
        }
    }
}
