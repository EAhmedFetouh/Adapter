

namespace Adapter
{
    public interface IPaymentProcessor
    {
        bool Pay(decimal amount, string currency);
    }
}
