using Leaders.RedeemVoucher.Domain.Interfaces.Repositories;
using Leaders.RedeemVoucher.Infra.DbContext;
using System.Collections.Generic;

namespace Leaders.RedeemVoucher.Infra.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly SqlServerContext dbContext;

        public RepositoryBase()
        {
            dbContext = new SqlServerContext();
        }
        public void Create(T obj)
        {
            dbContext.Set<T>().Add(obj);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            dbContext.Set<T>().Remove(dbContext.Set<T>().Find(id));
            dbContext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return dbContext.Set<T>();
        }

        public T GetById(int id)
        {
            return dbContext.Set<T>().Find(id);
        }

        public void Update(T obj)
        {
            
        }
    }
}
