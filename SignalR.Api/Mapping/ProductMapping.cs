using AutoMapper;
using SignalR.DTOLayer.ContactDTO;
using SignalR.DTOLayer.ProductDTO;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class ProductMapping :Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, CreateProductDTO>().ReverseMap();
            CreateMap<Product, GetProductDTO>().ReverseMap();
            CreateMap<Product, UpdateProductDTO>().ReverseMap();
            CreateMap<Product, ResultProductDTO>().ReverseMap();

        }
    }
}
