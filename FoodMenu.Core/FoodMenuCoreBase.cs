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
        protected readonly FoodMenuRepositoryBase<TEntity> FRepository;
       
        public virtual void Create(TEntity AEntity)
        {
            FRepository.Add(AEntity);
            FRepository.Save();
        }

        public virtual void Edit(TEntity AEntity)
        {
            FRepository.Edit(AEntity);
            FRepository.Save();
        }

        public virtual void Delete(int id)
        {
            FRepository.Delete(FRepository.Get(id));
            FRepository.Save();
        }

        public void Dispose()
        {
            FRepository.Dispose();
        }
    }
}
