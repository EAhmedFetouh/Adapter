# 🧩 Adapter Pattern – Multi Payment Gateway Integration

This project demonstrates the **Adapter Design Pattern** using a realistic architecture with **multiple Web APIs and a client application**.

---

## 🧠 Real-World Scenario

Your mobile or frontend app was originally integrated with **PayPal** only.

Then came the request:

> "We need to integrate with **Stripe** and **Paymob** too."

But here's the issue:
- Each provider exposes its own **Web API**.
- The request and response formats are different.
- You need to simulate that integration properly.

---

## 🧪 Project Simulation

To keep things close to real-world architecture, the solution contains:

| Project           | Description                            |
|-------------------|----------------------------------------|
| `PaypalAPP`       | Simulated PayPal Web API               |
| `StripeAPP`       | Simulated Stripe Web API               |
| `Paymob`          | Simulated Paymob Web API               |
| `Adapter`         | The shared domain & adapters           |
| `Adapter.Console` | Console app simulating the frontend    |

---

## ✅ Why Adapter Pattern?

Using Adapter Pattern, we created a **common interface `IPaymentProcessor`** that hides all differences between APIs.

So instead of:
```csharp
if (gateway == "paypal") { ... }
else if (gateway == "stripe") { ... }
