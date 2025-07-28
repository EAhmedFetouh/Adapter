using Microsoft.AspNetCore.Mvc;

namespace Paymob.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymobController : ControllerBase
    {
        [HttpPost]
        public IActionResult Pay([FromBody] PaymobRequest request)
        {
            if (request.amount_cents <= 0)
            {
                return Ok(new PaymobResponse
                {
                    Code = 402,
                    Message = "Insufficient funds"
                });
            }

            return Ok(new PaymobResponse
            {
                Code = 200,
                Message = "Payment successful"
            });
        }
    }
}
