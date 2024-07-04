using Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(ItemService.List());
        }
    }
}
