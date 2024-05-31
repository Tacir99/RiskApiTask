using AutoMapper;
using DTO.DTOS.ProductDTO;
using Entity.Concrete;

namespace DTO.AutoMapper;

public class ProductMapper:Profile
{
    public ProductMapper()
    {
       CreateMap<Product,GetProductDTO>().ReverseMap();
        CreateMap<Product,AddProductDTO>().ReverseMap();
        CreateMap<Product,UpdateProductDTO>().ReverseMap();
        CreateMap<Product, ProductListDTO>().ReverseMap();
    }
}
