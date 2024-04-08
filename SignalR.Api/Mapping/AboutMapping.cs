using AutoMapper;
using SignalR.DTOLayer.AboutDTO;
using SignalR.EntityLayer.Entities;
using System.Runtime;

namespace SignalR.Api.Mapping
{
    public class AboutMapping :Profile
    {
        public AboutMapping()
        {
            CreateMap<About,ResultAboutDTO>().ReverseMap(); 
            CreateMap<About,CreateAboutDTO>().ReverseMap();
            CreateMap<About,GetAboutDTO>().ReverseMap();
            CreateMap<About,UpdateAboutDTO>().ReverseMap();

        }
    }
}
