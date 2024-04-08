using AutoMapper;
using SignalR.DTOLayer.ContactDTO;
using SignalR.DTOLayer.FeatureDTO;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class FeatureMapping :Profile
    {
        public FeatureMapping()
        {
            CreateMap<Feature, CreateFeatureDTO>().ReverseMap();
            CreateMap<Feature, GetFeatureDTO>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDTO>().ReverseMap();
            CreateMap<Feature, ResultFeatureDTO>().ReverseMap();

        }
    }
}
