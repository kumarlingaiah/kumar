using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFIOCDIAFAMMVC.Data.Infrastructure;
using EFIOCDIAFAMMVC.Model;

namespace EFIOCDIAFAMMVC.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Save();
        IRepository<Employee> Employeerepository { get; }

    }
}
