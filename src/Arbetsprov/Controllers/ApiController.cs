using Arbetsprov.Models;
using Microsoft.AspNetCore.Mvc;

namespace Arbetsprov.Controllers {
    public class ApiController : Controller {
        [HttpGet("api/search")]
        public IActionResult Search([FromQuery] string query) {
            return new ObjectResult(new SearchResult { Query = query });
        }
    }
}