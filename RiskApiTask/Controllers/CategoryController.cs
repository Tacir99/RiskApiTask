using AutoMapper;
using Business.Service;
using DTO.DTOS.CategoryDTO;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _category;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService category,IMapper mapper)
        {
            _category = category;
            _mapper = mapper;   
        }

        [HttpGet("CategoryList")]
        public IActionResult GetList()
        {
            var values = _mapper.Map<IEnumerable<CategoryListDTO>>(_category.GetList());
            
            return Ok(values);
        }
        [HttpGet("GetById/{Id}")]
        public IActionResult GetById(int Id)
        {
            var values = _mapper.Map<GetCategoryDTO>(_category.GetById(Id));
            return Ok(values);
        }
        [HttpPost("Create")]
        public IActionResult Create(AddCategoryDTO dto)
        {
            Category category = new Category();
            _mapper.Map(dto, category);
          
            _category.Create(category);

            return Ok(category);
        }
        [HttpPut("Update")]
        public IActionResult Update(UpdateCategoryDTO dto)
        {
            var entity = _category.GetById(dto.Id);
            if (entity == null)
            {
                return NotFound("Category not found");
            }
            _mapper.Map(dto,entity);
            _category.Update(entity);
            return Ok("Yeniləndi!");
        }
        [HttpDelete("Delete/{Id}")]
        public IActionResult Delete(int Id)
        {
            if (Id == null)
            {
                return BadRequest("Bu Id uyğun kateqoriya mövcud deyil!");
            }
            var Entity = _category.GetById(Id);
            if (Entity==null)
            {
                return NotFound("Xəta!");
            }
            _category.Delete(Entity);   
            return Ok("Kateqoriya silindi!");
        }
       
    }
}
