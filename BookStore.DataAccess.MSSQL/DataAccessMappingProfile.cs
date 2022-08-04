using AutoMapper;
using BookStore.DataAccess.MSSQL.Entites;

namespace BookStore.DataAccess.MSSQL
{
    public class DataAccessMappingProfile : Profile
    {
        public DataAccessMappingProfile()
        {
            CreateMap<Domain.Book, Book>().ReverseMap();
        }
    }
}
