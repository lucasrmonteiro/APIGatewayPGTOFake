using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIGateway.BLL.Business;
using APIGateway.DTO.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace APIGateway.Query.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionBLL transactionBLL;

        public TransactionController(IConfiguration configuration , ITransactionBLL transaction)
        {
            transactionBLL = transaction;
            transaction.cString = configuration.GetSection("ConnectionStrings:DBGateway").ToString();
        }

        [HttpGet("Transactions")]
        public IActionResult GetTransacioctions(TransactionRequestDTO requestDTO)
        {
            try
            {
                return Ok(transactionBLL.GetTransacaoLojas(requestDTO.loja));
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
            
        }


        [HttpPost("NewTransaction")]
        public IActionResult NewTransaction(TransactionRequestDTO requestDTO)
        {
            try
            {
                return Ok(transactionBLL.CreateNewTransaction(requestDTO));
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }

        }
    }
}