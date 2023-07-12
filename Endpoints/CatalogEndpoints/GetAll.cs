using FastEndpoints;

namespace WebEndpoint.Endpoints.CatalogEndpoints
{
    public class GetAll : EndpointWithoutRequest
    {
        public GetAll()
        {

        }

        public override void Configure()
        {
            Verbs(Http.GET);
            Routes("example");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        { 
            await SendAsync(
                new
                {
                    message = "Test req"
                });
        }
    }
}
