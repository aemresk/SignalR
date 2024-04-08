using AutoMapper;
using SignalR.DTOLayer.CategoryDTO;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class CategoryMapping :Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category,CreateCategoryDTO>().ReverseMap();
            CreateMap<Category,UpdateCategoryDTO>().ReverseMap();
            CreateMap<Category,GetCategoryDTO>().ReverseMap();
            CreateMap<Category,ResultCategoryDTO>().ReverseMap();
        }
    }
}
