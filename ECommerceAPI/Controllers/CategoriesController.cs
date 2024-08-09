using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("GetCategory")]
        public IActionResult GetCategory(int id)
        {
            var result = _categoryService.GetCategory(id);

            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest(result);
        }


        [HttpGet("GetCategories")]
        public IActionResult GetAllCategories()
        {
            var result = _categoryService.GetAllCategories();

            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest(result);
        }


        [HttpPost("DeleteCategory")]
        public IActionResult Delete(int id)
        {
            var result = _categoryService.Delete(id);

            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest(result);
        }

        [HttpPost("UpdateCategory")]
        public IActionResult Update( Category category)
        {
            var result = _categoryService.Update(category);

            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest(result);
        }

        [HttpPost("AddCategory")]
        public IActionResult Add(Category category)
        {
            var result = _categoryService.Add(category);

            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest(result);
        }

    }
}
