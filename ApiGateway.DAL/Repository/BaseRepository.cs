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
        public string conString { get; set; }

        public long Add(TEntity entity)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                return con.Insert<TEntity>(entity); 
            }
        }

        public long Add(IEnumerable<TEntity> entity)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                return con.Insert<IEnumerable<TEntity>>(entity);
            }
        }

        public bool Delete(TEntity entity)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                return con.Delete<TEntity>(entity);
            }
        }

        public bool Delete(IEnumerable<TEntity> entity)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                return con.Delete<IEnumerable<TEntity>>(entity);
            }
        }

        public bool Update(TEntity entity)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                return con.Update<TEntity>(entity);
            }
        }

        public bool Update(IEnumerable<TEntity> entity)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                return con.Update<IEnumerable<TEntity>>(entity);
            }
        }

        public TEntity Get(int Id)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                return con.Get<TEntity>(Id);
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                return con.GetAll<TEntity>();
            }
        }

        public TEntity GetEntity(int Id)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                return con.Get<TEntity>(Id);
            }
        }

        public IEnumerable<TEntity> GetEntityByQuery(string sql)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                return con.Query<TEntity>(sql);
            }
        }

        public void ExecuteQuery(string sql)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Execute(sql);
            }
        }

    }
}
