using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFIOCDIAFAMMVC.Data.Infrastructure
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
