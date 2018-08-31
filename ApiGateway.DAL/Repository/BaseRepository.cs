using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ApiGateway.DAL.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private string _conString { get; set; }

        public BaseRepository(string connString)
        {
            _conString = connString;
        }

        public long Add(TEntity entity)
        {
            using (SqlConnection con = new SqlConnection())
            {
                return con.Insert<TEntity>(entity); 
            }
        }

        public long Add(IEnumerable<TEntity> entity)
        {
            using (SqlConnection con = new SqlConnection())
            {
                return con.Insert<IEnumerable<TEntity>>(entity);
            }
        }

        public bool Delete(TEntity entity)
        {
            using (SqlConnection con = new SqlConnection())
            {
                return con.Delete<TEntity>(entity);
            }
        }

        public bool Delete(IEnumerable<TEntity> entity)
        {
            using (SqlConnection con = new SqlConnection())
            {
                return con.Delete<IEnumerable<TEntity>>(entity);
            }
        }

        public bool Update(TEntity entity)
        {
            using (SqlConnection con = new SqlConnection())
            {
                return con.Update<TEntity>(entity);
            }
        }

        public bool Update(IEnumerable<TEntity> entity)
        {
            using (SqlConnection con = new SqlConnection())
            {
                return con.Update<IEnumerable<TEntity>>(entity);
            }
        }

        public TEntity Get(int Id)
        {
            using (SqlConnection con = new SqlConnection())
            {
                return con.Get<TEntity>(Id);
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            using (SqlConnection con = new SqlConnection())
            {
                return con.GetAll<TEntity>();
            }
        }

        public TEntity GetEntity(int Id)
        {
            using (SqlConnection con = new SqlConnection())
            {
                return con.Get<TEntity>(Id);
            }
        }

        public IEnumerable<TEntity> GetEntityByQuery(string sql)
        {
            using (SqlConnection con = new SqlConnection())
            {
                return con.Query<TEntity>(sql);
            }
        }

    }
}
