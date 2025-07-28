using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adapter.Stripe
{
    internal class StripeRequest
    {
        public double amount { get; set; }
        public string currency { get; set; }
        public string description { get; set; }
    }

}
