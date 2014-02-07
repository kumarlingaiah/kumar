using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFIOCDIAFAMMVC.Data.Dbcontexts;
using EFIOCDIAFAMMVC.Data.Infrastructure;
using EFIOCDIAFAMMVC.Model;

namespace EFIOCDIAFAMMVC.Data.UnitOfWork
{
    public class UnitOfWork<datacontext> : IDisposable, IUnitOfWork<datacontext> where datacontext : DbContext,new()
    {
        //private EFIOCDIAFAMMVCDbcontext EFIOCDIAFAMMVCDbcontext = new EFIOCDIAFAMMVCDbcontext();
        private IRepository<Employee> employeerepository;

        private DbContext _datacontext;

        public UnitOfWork()
        {
            _datacontext = new datacontext();
        }

        public IRepository<Employee> Employeerepository
        {
            get
            {
                if (employeerepository == null)
                {
                    this.employeerepository = new Repository<Employee>(_datacontext);
                }
                return employeerepository;
            }
        }

        public void Save()
        {
            _datacontext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _datacontext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
