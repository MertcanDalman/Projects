﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ContactDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
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
            var result = _mapper.Map<List<ResultContactDto>>(_contactService.TGetAllList());
            return Ok(result);
        }
        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            _contactService.TAdd(new Contact()
            {
                FooterDescription = createContactDto.FooterDescription,
                Location = createContactDto.Location,
                Mail = createContactDto.Mail,
                Phone = createContactDto.Phone,

            });
            return Ok("İletişim bilgisi eklendi!");
        }
        [HttpDelete]
        public IActionResult DeleteContact(int id) 
        { 
            var result = _contactService.TGetById(id);
            _contactService.TDelete(result);
            return Ok("İletişim bilgisi silindi!");
        }
        [HttpGet("GetContact")]
        public IActionResult GetContactById(int id)
        {
            var result = _contactService.TGetById(id);
            return Ok(result);
        }
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            _contactService.TUpdate(new Contact()
            {
                ContactId = updateContactDto.ContactId,
                FooterDescription = updateContactDto.FooterDescription,
                Location = updateContactDto.Location,
                Mail = updateContactDto.Mail,
                Phone = updateContactDto.Phone,
            });
            return Ok("Güncelleme başarılı bir şekilde yapıldı!");
        }
    }
}
