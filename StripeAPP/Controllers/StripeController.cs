using Microsoft.AspNetCore.Mvc;

namespace StripeAPP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StripeController : Controller
    {
        [HttpPost]
        public IActionResult Pay([FromBody] StripeRequest request)
        {
            if (request.amount < 0)
                return Ok(new { status = "DECLINED" });

            return Ok(new { status = "APPROVED" });
        }
    }
}
