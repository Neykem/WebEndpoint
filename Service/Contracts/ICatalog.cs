namespace WebEndpoint.Service.Contracts
{
    public interface ICatalog<T,T_dto>
    {
        Task<List<T_dto>> ReturnCatalogEntityAsync();
    }
}
