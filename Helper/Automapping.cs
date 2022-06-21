using AutoMapper;
using Webapi.Data;
using Webapi.Model;

namespace Webapi.Helper
{
    public class Automapping : Profile
    {
        public Automapping()
        {
            CreateMap<Books, BookModel>().ReverseMap();
        }
    }
}
