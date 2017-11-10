using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenu.Data.Interfaces
{
    public interface IFoodMenuRepositoryBase<TEntity> where TEntity: class
    {
        void Add(TEntity entity);
        TEntity Edit(TEntity entity);
        void Delete(TEntity entity);
        ICollection<TEntity> GetAll();
        void Save();

    }
}
