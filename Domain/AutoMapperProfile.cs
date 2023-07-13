using AutoMapper;
using WebEndpoint.Data;
using WebEndpoint.Endpoints.CatalogEndpoints.CatalogResult;

namespace WebEndpoint.Domain
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Book, BookResult>();
            //CreateMap<BookResult, Book>();
        }
    }
}
