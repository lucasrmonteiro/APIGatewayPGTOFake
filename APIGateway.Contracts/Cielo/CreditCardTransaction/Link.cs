using System;
using System.Collections.Generic;
using System.Text;

namespace APIGateway.Contracts.Cielo.CreditCardTransaction
{
    public class Link
    {
        public string Method { get; set; }
        public string Rel { get; set; }
        public string Href { get; set; }
    }
}
