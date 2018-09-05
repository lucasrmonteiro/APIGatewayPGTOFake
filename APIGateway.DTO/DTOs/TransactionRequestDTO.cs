using ApiGateway.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIGateway.DTO.DTOs
{
    public class TransactionRequestDTO
    {
        public Loja loja { get; set; }

        public CreditCardDTO creditCard { get; set; }

        public decimal valor { get; set; }
    }
}
