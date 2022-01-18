using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DockerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        public IActionResult TestMethod()
        {
            string query = "http://localhost:9000/";
            return Ok(query);
        }
    }
}
