using Ardalis.ApiEndpoints;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace WebEndpoint.Endpoints.CatalogEndpoints
{
    public class GetAll : EndpointBaseAsync.WithRequest<int>
      .WithActionResult<AuthorResult>
    {
        public override Task<ActionResult<AuthorResult>> HandleAsync(int request, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
