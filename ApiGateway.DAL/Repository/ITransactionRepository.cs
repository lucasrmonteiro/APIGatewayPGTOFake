using System.Collections.Generic;
using ApiGateway.DAL.Entity;

namespace ApiGateway.DAL.Repository
{
    public interface ITransactionRepository : IBaseRepository<TransacaoLoja>
    {
        void CreateNewTransaction(TransacaoLoja transaction);
        IEnumerable<TransacaoLoja> GetTransactions(Loja loja);
    }
}