using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.PayPal
{
    public class PayPalPaymentResult
    {
        public int StatusCode { get; set; } 
        public string Message { get; set; } 
    }
}
