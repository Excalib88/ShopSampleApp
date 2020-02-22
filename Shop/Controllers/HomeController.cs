using Microsoft.AspNetCore.Mvc;
using Shop.Domain;

namespace Shop.Controllers
{
    [Route("home")]
    public class HomeController : BaseController
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }
        
        // localhost:5000/home/get
        [HttpGet("get/")]
        public IActionResult Get()
        {
            var result = _homeService.Get(2);
            
            return Ok(result);
        }
        
        // localhost:5000/home/get/1
        [HttpGet("get/{id}")]
        public IActionResult Get(int id)
        {
            if (id == 0)
            {
                return BadRequest("Id не может быть равен 0");
            }
            
            var result = _homeService.Get(id);
            
            return Ok(result);
        }
    }
}