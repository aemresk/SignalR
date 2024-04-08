using AutoMapper;
using SignalR.DTOLayer.ContactDTO;
using SignalR.DTOLayer.TestimonialDTO;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class TestimonialMapping:Profile
    {
        public TestimonialMapping()
        {
            CreateMap<Testimonial, CreateTestimonialDTO>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDTO>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialDTO>().ReverseMap();
            CreateMap<Testimonial, ResultTestimonialDTO>().ReverseMap();

        }
    }
}
