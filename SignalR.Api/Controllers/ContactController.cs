using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.CategoryDTO;
using SignalR.DTOLayer.ContactDTO;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult ContactList()
        {

            var value = _mapper.Map<List<ResultContactDTO>>(_contactService.TGetListAll());

            return Ok(value);

        }

        [HttpPost]
        public IActionResult CreateContact(CreateContactDTO dto)
        {
            _contactService.TAdd(new Contact()
            {
                FooterDescription = dto.FooterDescription,
                Location = dto.Location,
                Mail=dto.Mail,
                Phone = dto.Phone
            });

            return Ok("İletişim eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetByID(id);
            _contactService.TDelete(value);
            return Ok("KAtegori Silindi");
        }

        [HttpGet("GetContact")]
        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateCategory(UpdateContactDTO upContactDto)
        {
            _contactService.TUpdate(new Contact()
            {
                FooterDescription = upContactDto.FooterDescription,
                Location = upContactDto.Location,
                Mail = upContactDto.Mail,
                Phone = upContactDto.Phone

            });
            return Ok("Güncelleme işlemi yapıldı.");
        }

    }
}
