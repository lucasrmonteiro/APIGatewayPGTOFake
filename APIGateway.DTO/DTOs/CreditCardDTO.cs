using System;
using System.Collections.Generic;
using System.Text;

namespace APIGateway.DTO.DTOs
{
    public class CreditCardDTO
    {
        public string numeroCartao { get; set; } 
        public string dataExpiracao { get; set; } 
        public string codigoSeguranca { get; set; }
        public string nomePropietario { get; set; }
        public string bandeira { get; set; }
    }
}
