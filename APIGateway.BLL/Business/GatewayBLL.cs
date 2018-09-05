using APIGateway.Contracts.Cielo.CreditCardTransaction;
using GatewayApiClient.DataContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIGateway.BLL.Business
{
    public class GatewayBLL
    {
        public CreditCardTransaction CieloMock(Contracts.Cielo.CreditCardTransaction.CreditCard creditCard)
        {
            try
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(0, 1);

                switch (randomNumber)
                {
                    case 0:
                        return null;
                    case 1:
                        return new CreditCardTransaction()
                        {
                            MerchantOrderId = "666",
                            Customer = null,
                            Payment = null
                        };
                    default:
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CreditCardTransactionResult StoneMock(GatewayApiClient.DataContracts.CreditCard creditCard)
        {
            try
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(0, 1);

                switch (randomNumber)
                {
                    case 0:
                        return null;
                    case 1:
                        return new CreditCardTransactionResult()
                        {
                            TransactionKey = Guid.NewGuid()
                        };
                    default:
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AntiFraudeMock()
        {
            try
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(0, 1);

                switch (randomNumber)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}
