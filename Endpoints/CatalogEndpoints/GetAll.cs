using Ardalis.ApiEndpoints;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebEndpoint.Endpoints.CatalogEndpoints.CatalogResult;

namespace WebEndpoint.Endpoints.CatalogEndpoints
{
    public class GetAll : EndpointBaseAsync.WithRequest<int>
      .WithActionResult<BookResult>
    {
        public override Task<ActionResult<BookResult>> HandleAsync(int request, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
