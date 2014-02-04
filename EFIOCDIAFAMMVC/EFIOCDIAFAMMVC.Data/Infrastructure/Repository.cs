using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFIOCDIAFAMMVC.Data.Dbcontexts;
using LawHelpInteractive.Data.Infrastructure;

namespace EFIOCDIAFAMMVC.Data.Infrastructure
{
    public class Repository<TEntity> :Disposable, IRepository<TEntity> where TEntity : class
    {
        private DbContext _DbContext = new EFIOCDIAFAMMVCDbcontext();
        private DbSet<TEntity> DbSet { get { return _DbContext.Set<TEntity>(); } }

        public List<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
            Commit();
        }

        public void Update(TEntity entity)
        {
            DbSet.Attach(entity);
            _DbContext.Entry(entity).State = EntityState.Modified;
            Commit();
        }

        public void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
            Commit();
        }

        private void Commit()
        {
            _DbContext.SaveChanges();
        }        
    }
}
