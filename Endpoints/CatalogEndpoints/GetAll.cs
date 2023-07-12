using FastEndpoints;

namespace WebEndpoint.Endpoints.CatalogEndpoints
{
    public class GetAll : EndpointWithoutRequest
    {
        private readonly Logger<GetAll> _logger;
        private readonly IMapper _mapper;
        public GetAll(Logger<GetAll> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
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
