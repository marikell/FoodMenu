using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenu.Data
{
    public class FoodMenuRepositoryBase<TEntity> : IDisposable where TEntity: class
    {
        protected FoodMenuContext Context;
        DbSet<TEntity> DbSet;

        public FoodMenuRepositoryBase()
        {
            Context = new FoodMenuContext();
            DbSet = Context.Set<TEntity>();

        }
        public virtual void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public virtual TEntity Edit(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public virtual TEntity Get(params object[] AKeys)
        {
            return DbSet.Find(AKeys);
        }

        public virtual void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
        }
        public virtual ICollection<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public virtual void Save()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
