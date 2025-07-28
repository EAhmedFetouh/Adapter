
using System.Net.Http.Json;

namespace Adapter.PayPal
{
    public class PayPalClient : IPaymentProcessor
    {
        private readonly HttpClient _http = new();

        public bool Pay(decimal amount, string currency)
        {
            var request = new PayPalRequest { amount = amount, currency = currency };

            var response = _http.PostAsJsonAsync(
                "https://localhost:7136/api/PayPal", request).Result;

            string raw = response.Content.ReadAsStringAsync().Result;
            return bool.Parse(raw);
        }
    }
}
