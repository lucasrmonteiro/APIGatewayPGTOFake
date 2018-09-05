using System.Collections.Generic;
using ApiGateway.DAL.Entity;

namespace ApiGateway.DAL.Repository
{
    public interface IConfiguracaoLojaRepository : IBaseRepository<ConfiguracaoLoja>
    {
        ConfiguracaoLoja GetConfiguracaoLoja(Loja loja , Bandeira bandeira);
    }
}