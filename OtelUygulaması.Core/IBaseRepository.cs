using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelUygulaması.Core
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        int Create(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);

        
        TEntity GetById(int ıd);

        ICollection<TEntity> GetAll();
    }
}
