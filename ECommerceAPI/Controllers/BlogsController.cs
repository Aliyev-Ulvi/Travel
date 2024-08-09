using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IBlogService _blogService;

        public BlogsController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet("GetBlog")]
        public IActionResult GetBlog(int id)
        {
            var result = _blogService.GetBlog(id);

            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest(result);
        }


        [HttpGet("GetBlogs")]
        public IActionResult GetAllBlogs()
        {
            var result = _blogService.GetAllBlogs();

            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest(result);
        }


        [HttpPost("DeleteBlog")]
        public IActionResult Delete(int id)
        {
            var result = _blogService.Delete(id);

            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest(result);
        }

        [HttpPost("UpdateBlog")]
        public IActionResult Update(int id, Blog blog)
        {
            var result = _blogService.Update(id, blog);

            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest(result);
        }

        [HttpPost("AddBlog")]
        public IActionResult Add(Blog blog)
        {
            var result = _blogService.Add(blog);

            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest(result);
        }
    }
}
