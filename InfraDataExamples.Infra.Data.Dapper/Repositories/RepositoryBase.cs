using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using InfraDataExamples.Domain.Core.Interfaces.Entities;
using InfraDataExamples.Domain.Core.Interfaces.Repositories;
using Dapper.Contrib.Extensions;

namespace InfraDataExamples.Infra.Data
{
    public class RepositoryBase<TEntity, TKey> : IRepositoryBase<TEntity, TKey> where TEntity : class, IEntityBase<TKey>
    {
        private readonly string connStr;

        public RepositoryBase()
        {
            connStr = ConfigurationManager.ConnectionStrings["InfraDataExamplesContext"].ConnectionString;
        }

        public virtual TEntity GetById(TKey id)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                return con.Get<TEntity>(id);
            }
        }

        public virtual IEnumerable<TEntity> GetAll(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                //return con.GetAll<TEntity>()
            }
        }

        public virtual void Create(TEntity obj)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Insert(obj);
            }
        }

        public virtual void Edit(TEntity obj)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Update(obj);
            }
        }

        public virtual void Delete(TEntity obj)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Delete(obj);
            }
        }
    }
}
