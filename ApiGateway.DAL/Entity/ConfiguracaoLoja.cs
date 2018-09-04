using System;
using System.Collections.Generic;
using System.Text;

namespace ApiGateway.DAL.Entity
{
    public class ConfiguracaoLoja
    {
        public int idConfig { get; set; }
        public Loja loja { get; set; }
        public Bandeira bandeira { get; set; }
        public GatewayPgtos gateway { get; set; }
        public bool flUseAntiFraude { get; set; }
    }
}
