
using Adapter.PayPal;

namespace Adapter
{
    public class CheckoutService
    {
        private readonly IPaymentProcessor _payment;

        public CheckoutService(IPaymentProcessor payment)
        {
            _payment = payment;
        }

        public void Checkout(decimal amount, string currency,string description)
        {
            bool ok = _payment.Pay(amount, currency);

            Console.WriteLine(ok
                ? "✅ Payment succeeded"
                : "❌ Payment failed");
        }
    }

}
