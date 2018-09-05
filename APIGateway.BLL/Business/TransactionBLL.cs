using ApiGateway.DAL.Entity;
using ApiGateway.DAL.Repository;
using APIGateway.Contracts.Cielo.CreditCardTransaction;
using APIGateway.DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIGateway.BLL.Business
{
    public class TransactionBLL : ITransactionBLL
    {
        private ITransactionRepository transactionRepository { get; set; }

        private IConfiguracaoLojaRepository configuracaoLojaRepository { get; set; }

        public string cString { get; set; }

        public TransactionBLL(ITransactionRepository transaction , IConfiguracaoLojaRepository configuracaoLoja)
        {
            transactionRepository = transaction;
            configuracaoLojaRepository = configuracaoLoja;
            transactionRepository.conString = cString;
            configuracaoLojaRepository.conString = cString;
        }

        public TransacaoLoja CreateNewTransaction(TransactionRequestDTO req)
        {
            var bandeira = GetBandeira(req.creditCard.bandeira);

            var config = configuracaoLojaRepository.GetConfiguracaoLoja(req.loja ,bandeira);

            if (config == null)
                throw new Exception("Loja não possui configuração");

            var gatewayBll = new GatewayBLL();

            if (config.flUseAntiFraude)
            {
                var validateFraude = gatewayBll.AntiFraudeMock();

                if (validateFraude)
                {
                    var tran = SetTransactionByGateway(config.gateway, req);
                    return tran;
                }
                else
                {
                    return null;
                }
            }
            else
            {

                var tran = SetTransactionByGateway(config.gateway, req);

                return tran;

            }

        }

        private TransacaoLoja SetTransactionByGateway(GatewayPgtos gateway , TransactionRequestDTO req)
        {
            var gatewayBll = new GatewayBLL();

            if (gateway.nomeGateway == "Cielo")
            {
                return CretaCieloTransaction(gateway, req, gatewayBll);
            }
            else
            {
                return CreateStoneTransaction(gateway, req, gatewayBll);
            }
        }

        private TransacaoLoja CreateStoneTransaction(GatewayPgtos gateway, TransactionRequestDTO req, GatewayBLL gatewayBll)
        {
            var data = gatewayBll.StoneMock(new GatewayApiClient.DataContracts.CreditCard()
            {
                CreditCardNumber = req.creditCard.numeroCartao,
                ExpYear = Convert.ToInt32(req.creditCard.dataExpiracao),
                ExpMonth = Convert.ToInt32(req.creditCard.nomePropietario),
                SecurityCode = req.creditCard.codigoSeguranca
            });


            var transaction = new TransacaoLoja()
            {
                loja = req.loja,
                status = data != null ? true : false,
                valor = req.valor
            };

            transactionRepository.CreateNewTransaction(transaction);

            return transaction;
        }

        private TransacaoLoja CretaCieloTransaction(GatewayPgtos gateway, TransactionRequestDTO req, GatewayBLL gatewayBll)
        {
                var data = gatewayBll.CieloMock(new CreditCard()
                {
                    Brand = req.creditCard.bandeira,
                    CardNumber = req.creditCard.numeroCartao,
                    ExpirationDate = req.creditCard.dataExpiracao,
                    Holder = req.creditCard.nomePropietario,
                    SecurityCode = req.creditCard.codigoSeguranca
                });

                var transaction = new TransacaoLoja()
                {
                    loja = req.loja,
                    status = data != null ? true : false,
                    valor = req.valor
                };

                transactionRepository.CreateNewTransaction(transaction);

                return transaction;
        }

        public IEnumerable<TransacaoLoja> GetTransacaoLojas(Loja loja)
        {
            return transactionRepository.GetTransactions(loja);
        }

        private Bandeira GetBandeira(string nome)
        {
            switch (nome)
            {
                case "Visa":
                    return new Bandeira()
                    {
                        idBandeira = 1,
                        nomeBandeira = "Visa"
                    };
                case "Mastercard":
                    return new Bandeira()
                    {
                        idBandeira = 2,
                        nomeBandeira = "Mastercard"
                    };
                default:
                    return null;
            }
        }
    }
}
