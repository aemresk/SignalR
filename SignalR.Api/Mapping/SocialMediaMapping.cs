using AutoMapper;
using SignalR.DTOLayer.ContactDTO;
using SignalR.DTOLayer.SocialMediaDTO;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class SocialMediaMapping :Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<SocialMedia, CreateSocialMediaDTO>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialMediaDTO>().ReverseMap();
            CreateMap<SocialMedia, GetSocialMediaDTO>().ReverseMap();
            CreateMap<SocialMedia, ResultSocialMediaDTO>().ReverseMap();

        }
    }
}
