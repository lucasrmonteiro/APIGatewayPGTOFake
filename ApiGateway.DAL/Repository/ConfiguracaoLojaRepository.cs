using ApiGateway.DAL.Entity;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ApiGateway.DAL.Repository
{
    public class ConfiguracaoLojaRepository : BaseRepository<ConfiguracaoLoja>, IConfiguracaoLojaRepository
    {
        public IList<ConfiguracaoLoja> GetConfiguracaoLoja(Loja loja)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    var result = con.Query<ConfiguracaoLoja, Loja, Bandeira, GatewayPgtos , ConfiguracaoLoja>
                        (
                         "SELECT * FROM ConfiguracaoLoja WHERE idLoja = @idLoja",
                         map:(l,b ,g ,c) => {
                             l.loja = b;
                             l.bandeira = g;
                             l.gateway = c;

                             return l;
                         },
                         splitOn: "IdLoja,IdBandeira,IdGateway",
                         param:  new { @idLoja = loja.idLoja.ToString() }
                        ).AsList();

                    return result;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
