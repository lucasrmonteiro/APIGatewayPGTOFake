using System.Collections.Generic;
using ApiGateway.DAL.Entity;
using APIGateway.DTO.DTOs;

namespace APIGateway.BLL.Business
{
    public interface ITransactionBLL
    {
        TransacaoLoja CreateNewTransaction(TransactionRequestDTO loja);
        IEnumerable<TransacaoLoja> GetTransacaoLojas(Loja loja);
        string cString { get; set; }
    }
}