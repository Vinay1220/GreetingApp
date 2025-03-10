using BusinessLayer.Interface;
using Microsoft.AspNetCore.Mvc;
using ModelLayer;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetController : ControllerBase
    {
        private readonly IGreetBL _greetBL;

        public GreetController(IGreetBL greetBL)
        {
            _greetBL = greetBL;
        }

        [HttpPost("greeting")]
        public IActionResult GetGreeting([FromBody] User user)
        {
            var message = _greetBL.GetGreeting(user);
            return Ok(new ResponseModel<string> { Status = 200, Message = "Success", Data = message });
        }
    }
}
