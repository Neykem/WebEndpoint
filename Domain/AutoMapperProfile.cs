using AutoMapper;
using WebEndpoint.Data.Entity;
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
