using AutoMapper;
using Business.Service;
using DTO.DTOS.CategoryDTO;
using DTO.DTOS.ProductDTO;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class ProductController : ControllerBase
    {
        private readonly ICategoryService _category;
        private readonly IProductService _product;
        private readonly IMapper _mapper;

        public ProductController(ICategoryService category, IProductService product,IMapper mapper)
        {
            _category = category;
            _product = product;
            _mapper = mapper;
        }
        #region Get
        [HttpGet("ProductList")]
        public IActionResult GetProductList()
        {
           
            var dtos = _mapper.Map<IEnumerable<ProductListDTO>>(_product.GetList());
            return Ok(dtos);
        }
        [HttpGet("GetById/{Id}")]
        public IActionResult GetById(int Id)
        {
            var values = _mapper.Map<GetProductDTO>(_product.GetById(Id));
            return Ok(values);
        }
       
        #endregion
        #region Create
        [HttpPost("Create")]
        public IActionResult CreateProduct(AddProductDTO dto)
        {
            Product product = new Product();
            _mapper.Map(dto, product);
            _product.Create(product);
            return Ok("Məhsul əlavə edildi!");
        }
        #endregion
        #region Update
        [HttpPut("UpdateProduct")]
        public IActionResult Update(UpdateProductDTO dto)
        {
            var entity = _product.GetById(dto.Id);
            if (entity == null)
            {
                return NotFound("Məhsul tapılmadı!");
            }
            _mapper.Map(dto, entity);
            _product.Update(entity);
            return Ok("Məhsul yeniləndi!");
        }
        #endregion
        #region Delete
        [HttpDelete("/DeleteProduct/{Id}")]
        public IActionResult DeleteProduct(int Id) {

            if (Id == null)
            {
                return BadRequest("Bu Id uyğun kateqoriya mövcud deyil!");
            }
            var Entity = _product.GetById(Id);
            if (Entity == null)
            {
                return NotFound("Xəta!");
            }
            _product.Delete(Entity);

            return Ok("Məhsul silindi!");
        }
        #endregion
    }
}
