using AutoMapper;
using PruebaEFCore.DataAccess.Model;
using PruebaEFCore.Domain.Model;
using PruebaEFCore.ViewModel;

namespace PruebaEFCore.Domain.Utilidades
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<BlogViewModel, BlogDto>();
            CreateMap<BlogDto, BlogViewModel>();
            CreateMap<BlogDto, Blog>();
            CreateMap<Blog, BlogDto>();
        }
    }
}
