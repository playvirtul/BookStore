using AutoMapper;
using BookStore.API.Contracts;

namespace BookStore.API
{
    public class ApiMappingProfile : Profile
    {
        public ApiMappingProfile()
        {
            CreateMap<Domain.Book, GetBookResponse>().ReverseMap();
        }
    }
}
