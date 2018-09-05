using System;
using System.Collections.Generic;
using System.Text;

namespace ApiGateway.DAL.Entity
{
    public class TransacaoLoja
    {
        public long idTransacao { get; set; }
        public Loja loja { get; set; }
        public decimal valor { get; set; }
        public bool status { get; set; }
    }
}
