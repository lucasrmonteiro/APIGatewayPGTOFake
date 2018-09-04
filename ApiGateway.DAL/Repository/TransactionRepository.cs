using ApiGateway.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiGateway.DAL.Repository
{
    public class TransactionRepository : BaseRepository<TransacaoLoja>, ITransactionRepository
    {
        public void CreateNewTransaction(TransacaoLoja transaction)
        {
            try
            {
                int tr = transaction.status ? 1 : 0; ;
                var sql = "INSERT INTO TransacaoLoja VALUES (" + transaction.loja.idLoja.ToString() + "," + transaction.valor.ToString() + " ," + tr.ToString() + ")";
                ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TransacaoLoja> GetTransactions(Loja loja)
        {
            try
            {
                var sql = "SELECT * FROM TransacaoLoja WHERE idLoja =" + loja.idLoja.ToString();

                return GetEntityByQuery(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
