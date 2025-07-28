using Microsoft.AspNetCore.Mvc;

namespace PaypalAPP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PayPalController : Controller
    {
        [HttpPost]
        public IActionResult Pay([FromBody] PayPalRequest request)
        {
            if (request.amount <= 0)
            {
                return Ok(false);
            }

            return Ok(true);
        }
    }

}
