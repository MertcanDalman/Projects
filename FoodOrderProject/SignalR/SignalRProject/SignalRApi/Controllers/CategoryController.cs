﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.CategoryDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(IMapper mapper, ICategoryService categoryService)
        {
            _mapper = mapper;
            _categoryService = categoryService;
        }
        [HttpGet]
        public ActionResult CategoryList() 
        {
            var value  = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetAllList());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            _categoryService.TAdd(new Category()
            {
                CategoryName = createCategoryDto.CategoryName,
                Status = createCategoryDto.Status,
            });
            return Ok("Kategori eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
           var value = _categoryService.TGetById(id);
            _categoryService.TDelete(value);
            return Ok("Kategori silindi!");
        }
        [HttpGet("GetCategory")]
        public IActionResult GetCategoryById(int id)
        {
            var value = _categoryService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            _categoryService.TUpdate(new Category()
            {
                 CategoryId = updateCategoryDto.CategoryId,
                  CategoryName = updateCategoryDto.CategoryName,
                   Status = updateCategoryDto.Status,
            });
            return Ok("Kategori eklendi!");
        }
    }
}
