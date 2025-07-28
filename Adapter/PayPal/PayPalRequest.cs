using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.PayPal
{
    public class PayPalRequest
    {
        public decimal amount { get; set; }
        public string currency { get; set; }
    }
}
