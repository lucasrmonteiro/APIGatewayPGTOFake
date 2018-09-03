﻿using System;
using System.Collections.Generic;
using System.Text;

namespace APIGateway.Contracts.Cielo.CreditCardTransaction
{
    public class Payment
    {
        public int ServiceTaxAmount { get; set; }
        public int Installments { get; set; }
        public string Interest { get; set; }
        public bool Capture { get; set; }
        public bool Authenticate { get; set; }
        public CreditCard CreditCard { get; set; }
        public string ProofOfSale { get; set; }
        public string Tid { get; set; }
        public string AuthorizationCode { get; set; }
        public string PaymentId { get; set; }
        public string Type { get; set; }
        public int Amount { get; set; }
        public string Currency { get; set; }
        public string Country { get; set; }
        public List<object> ExtraDataCollection { get; set; }
        public int Status { get; set; }
        public string ReturnCode { get; set; }
        public string ReturnMessage { get; set; }
        public List<Link> Links { get; set; }
    }
}
