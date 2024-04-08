using AutoMapper;
using SignalR.DTOLayer.ContactDTO;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class ContactMapping :Profile
    {
        public ContactMapping()
        {
            CreateMap<Contact, CreateContactDTO>().ReverseMap();
            CreateMap<Contact, GetContactDTO>().ReverseMap();
            CreateMap<Contact, UpdateContactDTO>().ReverseMap();
            CreateMap<Contact, ResultContactDTO>().ReverseMap();

        }

    }
}
