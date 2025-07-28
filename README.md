# ♻️ Adapter Pattern – Multi Payment Gateway Integration

This project demonstrates the **Adapter Design Pattern** using a realistic architecture with multiple Web APIs and a client application.

---

## 🌍 Real-World Scenario

Your mobile or frontend app was originally integrated with PayPal only.

Then came the request:

> “We need to integrate with Stripe and Paymob too.”

But here’s the issue:

- Each provider exposes its own **Web API**
- The request and response formats are different
- You need to simulate that integration properly

---

## 🏗️ Project Simulation

To keep things close to real-world architecture, the solution contains:

| Project          | Description                      |
|------------------|----------------------------------|
| `PaypalAPP`      | Simulated PayPal Web API         |
| `StripeAPP`      | Simulated Stripe Web API         |
| `Paymob`         | Simulated Paymob Web API         |
| `Adapter`        | The shared domain & adapters     |
| `Adapter.Console`| Console app simulating frontend  |

---

## 🤔 Why Adapter Pattern?

Using Adapter Pattern, we created a **common interface** `IPaymentProcessor` that hides all differences between APIs.

So instead of:
```csharp
if (gateway == "paypal") { ... }
else if (gateway == "stripe") { ... }
```

We can just do:
```csharp
IPaymentProcessor processor = ResolveAdapter(gateway);
var checkout = new CheckoutService(processor);
checkout.Checkout(amount, "USD", gateway);
```

This makes the system:

- ✅ **Extensible** — Add new gateways without touching core logic
- ✅ **Clean** — No more If–Else chaos
- ✅ **Decoupled** — Business logic doesn’t care about API details

---

## 🚀 How to Run

1. Make sure all 3 Web APIs are running:
   - `PaypalAPP`
   - `StripeAPP`
   - `Paymob`

2. Run the `Adapter.Console` project.

3. Follow the prompts:
   - Choose gateway: `paypal`, `stripe`, or `paymob`
   - Enter the amount

---

## 📦 Sample Output

```plaintext
Choose gateway (paypal / stripe / exit): stripe
Amount: 200

✅ Connected to Stripe API
💵 Payment of 200 USD processed successfully via Stripe.
```

---

## 🎥 Related Links

- ▶️ **YouTube Video:** [https://youtu.be/D5Mvo6yLkHA](https://youtu.be/D5Mvo6yLkHA)
- 💻 **GitHub Repo:** [https://github.com/EAhmedFetouh/Adapter](https://github.com/EAhmedFetouh/Adapter)

---

## 🧠 Keywords
`Adapter Pattern` · `Clean Architecture` · `Design Patterns` · `C#` · `Console App` · `Multiple Payment Gateways` · `SOLID Principles`
