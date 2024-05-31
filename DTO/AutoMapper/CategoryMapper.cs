using AutoMapper;
using DTO.DTOS.CategoryDTO;
using Entity.Concrete;

namespace DTO.AutoMapper;

public class CategoryMapper : Profile
{
    public CategoryMapper()
    {
        CreateMap<Category, AddCategoryDTO>().ReverseMap();
        CreateMap<Category, UpdateCategoryDTO>().ReverseMap();
        CreateMap<Category, GetCategoryDTO>().ReverseMap();
        CreateMap<Category, CategoryListDTO>().ReverseMap();
    }
}
