using System.Collections.Generic;
using ApiGateway.DAL.Entity;

namespace ApiGateway.DAL.Repository
{
    public interface IConfiguracaoLojaRepository : IBaseRepository<ConfiguracaoLoja>
    {
        IList<ConfiguracaoLoja> GetConfiguracaoLoja(Loja loja);
    }
}