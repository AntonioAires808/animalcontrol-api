using System;
using Microsoft.AspNetCore.Mvc;

namespace animalcontrol_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OwnerController : ControllerBase
    {
        public IActionResult Get()
        {
            try
            {
                throw new Exception("test");
            }
            catch (Exception e)
            {
                                
                return BadRequest($"Error: {e.Message}");
            }

        }
    }
}