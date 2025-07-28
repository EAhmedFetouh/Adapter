using System.Text;
using Adapter;
using Adapter.Adapter.Stripe;
using Adapter.PayPal;

Console.OutputEncoding = Encoding.UTF8;


while (true)
{
    Console.Write("Choose gateway (paypal / stripe / exit): ");
    string gateway = Console.ReadLine()?.Trim().ToLower();
    Console.Write("Amount: ");
    decimal amount = decimal.Parse(Console.ReadLine());

    IPaymentProcessor processor;

    if (gateway == "exit")
        break;

    if (gateway == "paypal")
    {
        processor = new PayPalClient();

    }

    else if (gateway == "stripe")
        processor = new StripeAdapter();

    else
    {
        Console.WriteLine("❌ Invalid choice. Try again.\n");
        continue;
    }

    var checkout = new CheckoutService(processor);
    checkout.Checkout(amount, "USD", gateway);
}

Console.WriteLine("Goodbye 👋");
