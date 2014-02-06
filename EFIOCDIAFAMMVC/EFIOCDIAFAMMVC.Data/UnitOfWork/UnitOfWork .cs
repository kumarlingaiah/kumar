using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFIOCDIAFAMMVC.Data.Dbcontexts;
using EFIOCDIAFAMMVC.Data.Infrastructure;
using EFIOCDIAFAMMVC.Model;

namespace EFIOCDIAFAMMVC.Data.UnitOfWork
{
    public class UnitOfWork : IDisposable,IUnitOfWork
    {
        private EFIOCDIAFAMMVCDbcontext EFIOCDIAFAMMVCDbcontext = new EFIOCDIAFAMMVCDbcontext();
        private IRepository<Employee> employeerepository;

        public IRepository<Employee> Employeerepository
        {
            get
            {
                if (employeerepository == null)
                {
                    this.employeerepository = new Repository<Employee>(EFIOCDIAFAMMVCDbcontext);
                }
                return employeerepository;
            }
        }

        public void Save()
        {
            EFIOCDIAFAMMVCDbcontext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    EFIOCDIAFAMMVCDbcontext.Dispose();
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
