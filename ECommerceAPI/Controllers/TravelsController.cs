using Business.Abstract;
using Core.Helpers.Result.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelsController : ControllerBase
    {
        private readonly ITravelService _travelService;
        public TravelsController(ITravelService travelService)
        {
            _travelService = travelService;
        }



        [HttpGet("GetTravel")]
        public IActionResult GetTravel(int id) 
        {
            var result = _travelService.GetTravel(id);

            if (result.Success) 
            { 
                return Ok(result);
            }
            else
                return BadRequest(result);
        }


        [HttpGet("GetTravels")]
        public IActionResult GetAllTravels()
        {
            var result = _travelService.GetAllTravels();

            if (result.Success) 
            {
                return Ok(result);
            }
            else
                return BadRequest(result); 
        }


        [HttpPost("DeleteTravel")]
        public IActionResult Delete(int id) 
        { 
            var result = _travelService.Delete(id);

            if (result.Success) 
            {
                return Ok(result);
            }
            else
                return BadRequest(result);
        }

        [HttpPost("UpdateTravel")]
        public IActionResult Update(int id)
        {
            var result = _travelService.Update(id);

            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest(result);
        }

        [HttpPost("AddTravel")]
        public IActionResult Add(Travel travel)
        {
            var result = _travelService.Add(travel);

            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest(result);
        }


    }
}