using System.Collections.Generic;
using ApiGateway.DAL.Entity;

namespace APIGateway.BLL.Business
{
    public interface ITransactionBLL
    {
        void CreateNewTransaction();
        IEnumerable<TransacaoLoja> GetTransacaoLojas(Loja loja);
    }
}