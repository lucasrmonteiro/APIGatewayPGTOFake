using ApiGateway.DAL.Entity;
using ApiGateway.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIGateway.BLL.Business
{
    public class TransactionBLL : ITransactionBLL
    {
        private ITransactionRepository transactionRepository { get; set; }

        private IConfiguracaoLojaRepository configuracaoLojaRepository { get; set; }

        public TransactionBLL(ITransactionRepository transaction , IConfiguracaoLojaRepository configuracaoLoja ,string cString)
        {
            transactionRepository = transaction;
            configuracaoLojaRepository = configuracaoLoja;
            transactionRepository.conString = cString;
            configuracaoLojaRepository.conString = cString;
        }

        public void CreateNewTransaction()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TransacaoLoja> GetTransacaoLojas(Loja loja)
        {
            return transactionRepository.GetTransactions(loja);
        }
    }
}
