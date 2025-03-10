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

        [HttpPost]
        public IActionResult AddGreet([FromBody] Greet greet)
        {
            var createdGreet = _greetBL.AddGreet(greet);
            return Ok(new ResponseModel<Greet> { Status = 200, Message = "Greet added successfully", Data = createdGreet });
        }

        [HttpGet("{id}")]
        public IActionResult GetGreetById(int id)
        {
            var greet = _greetBL.GetGreetById(id);
            return greet != null
                ? Ok(new ResponseModel<Greet> { Status = 200, Message = "Success", Data = greet })
                : NotFound(new ResponseModel<string> { Status = 404, Message = "Greet not found", Data = null });
        }

        [HttpGet]
        public IActionResult GetAllGreets()
        {
            var greets = _greetBL.GetAllGreets();
            return Ok(new ResponseModel<List<Greet>> { Status = 200, Message = "Success", Data = greets });
        }

        [HttpPut]
        public IActionResult UpdateGreet([FromBody] Greet greet)
        {
            var updatedGreet = _greetBL.UpdateGreet(greet);
            return Ok(new ResponseModel<Greet> { Status = 200, Message = "Greet updated successfully", Data = updatedGreet });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGreet(int id)
        {
            bool isDeleted = _greetBL.DeleteGreet(id);
            return isDeleted
                ? Ok(new ResponseModel<string> { Status = 200, Message = "Greet deleted successfully", Data = null })
                : NotFound(new ResponseModel<string> { Status = 404, Message = "Greet not found", Data = null });
        }
    }
}
