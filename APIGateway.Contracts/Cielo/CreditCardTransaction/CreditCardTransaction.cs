using System;
using System.Collections.Generic;
using System.Text;

namespace APIGateway.Contracts.Cielo.CreditCardTransaction
{
    public class CreditCardTransaction
    {
        public string MerchantOrderId { get; set; }
        public Customer Customer { get; set; }
        public Payment Payment { get; set; }
    }
}
