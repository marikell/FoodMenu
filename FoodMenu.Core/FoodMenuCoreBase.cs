using FoodMenu.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenu.Core
{
    public class FoodMenuCoreBase<TEntity>: IDisposable where TEntity:class,new()
    {
        protected readonly FoodMenuRepositoryBase<TEntity> Repository;
       
        public virtual void Create(TEntity AEntity)
        {
            Repository.Add(AEntity);
            Repository.Save();
        }

        public virtual void Edit(TEntity AEntity)
        {
            Repository.Edit(AEntity);
            Repository.Save();
        }

        public virtual void Delete(int id)
        {
            Repository.Delete(Repository.Get(id));
            Repository.Save();
        }

        public void Dispose()
        {
            Repository.Dispose();
        }
    }
}
