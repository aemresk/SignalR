using AutoMapper;
using SignalR.DTOLayer.ContactDTO;
using SignalR.DTOLayer.DiscountDTO;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class DiscountMapping :Profile
    {
        public DiscountMapping()
        {
            CreateMap<Discount, CreateDiscountDTO>().ReverseMap();
            CreateMap<Discount, GetDiscountDTO>().ReverseMap();
            CreateMap<Discount, UpdateDiscountDTO>().ReverseMap();
            CreateMap<Discount, ResultDiscountDTO>().ReverseMap();

        }
    }
}
