using Microsoft.AspNetCore.Mvc;

namespace rizolog.api.users.Api.Controllers
{
    [ApiController]
    [Route("/")]
    public class RootController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("API levantó correctamente ");
        }
    }
}
