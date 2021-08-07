using Microsoft.AspNetCore.Mvc;

namespace animalcontrol_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OwnerController : ControllerBase
    {
        public IActionResult Get()
        {
            return BadRequest("Antonio");
        }
    }
}