using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adapter.Stripe
{
    public class StripeAdapter : IPaymentProcessor
    {
        private readonly HttpClient _http = new();
        public bool Pay(decimal amount, string currency)
        {
            var request = new StripeRequest
            {
                amount = (double)amount,
                currency = currency,
                description = "Checkout from adapter demo"
            };


            var respone = _http.PostAsJsonAsync("https://localhost:7044/api/Stripe", request).Result;

            var result = respone.Content.ReadFromJsonAsync<StripeRespone>().Result;

            return result.status == "APPROVED";


        }
    }
}
