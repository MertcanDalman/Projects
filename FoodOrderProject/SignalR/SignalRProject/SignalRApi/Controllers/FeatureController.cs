﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.FeatureDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;

        public FeatureController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetFeatureList() 
        {
            var result = _mapper.Map<List<ResultFeatureDto>>(_featureService.TGetAllList());
            return Ok(result);
        }
        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
        {
            _featureService.TAdd(new Feature()
            {
                Description1 = createFeatureDto.Description1,
                Description2 = createFeatureDto.Description2,
                Description3 = createFeatureDto.Description3,
                Title1 = createFeatureDto.Title1,
                Title2 = createFeatureDto.Title2,
                Title3 = createFeatureDto.Title3,
            });
            return Ok("Öne çıkan bilgisi başarılı bir şekilde eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteFeature(int id)
        {
            var result = _featureService.TGetById(id);
            _featureService.TDelete(result);
            return Ok("Öne çıkan bilgisi başarılı bir şekile eklendi");
        }
        [HttpGet("GetFeature")]
        public IActionResult GetFeatureById(int id) 
        {
            var result = _featureService.TGetById(id);
            return Ok(result);
        }
        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            _featureService.TUpdate(new Feature()
            {
                Description1 = updateFeatureDto.Description1,
                Description2 = updateFeatureDto.Description2,
                Description3 = updateFeatureDto.Description3,
                FeatureId = updateFeatureDto.FeatureId,
                Title1 = updateFeatureDto.Title1,
                Title2 = updateFeatureDto.Title2,
                Title3 = updateFeatureDto.Title3,
            });
            return Ok("Öne çıkan bigilisi başarılı bir şekilde güncellendi");
        }
    }
}
