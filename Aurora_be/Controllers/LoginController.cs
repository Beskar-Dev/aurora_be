using Microsoft.AspNetCore.Mvc;

namespace Aurora_be.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(string user = "", string? password = "")
        {
            if(user.Equals("julianlondono@outlook.com", StringComparison.OrdinalIgnoreCase) && password.Equals("Julian123*", StringComparison.OrdinalIgnoreCase))
            {
                return Ok("entra al post");
            }
            
            return NotFound("no entra al post");
        }

        [HttpGet]
        public IActionResult test()
        {
            var test = Request.Host;
            var test2 = Request.Path;
            return Ok("Todo OK ");
        }
    }
}
