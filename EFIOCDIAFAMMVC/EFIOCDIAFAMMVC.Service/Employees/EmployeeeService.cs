using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFIOCDIAFAMMVC.Data.UnitOfWork;
using EFIOCDIAFAMMVC.Model;
using EFIOCDIAFAMMVC.Data.Dbcontexts;

namespace EFIOCDIAFAMMVC.Service.Employees
{
    public class EmployeeeService : IEmployeeeService
    {
        private IUnitOfWork<EFIOCDIAFAMMVCSecondDbcontext> _iunitofworkk;
        private IUnitOfWork<EFIOCDIAFAMMVCDbcontext> _iunitofworkkfirst;

        public EmployeeeService(IUnitOfWork<EFIOCDIAFAMMVCSecondDbcontext> iunitofwork, IUnitOfWork<EFIOCDIAFAMMVCDbcontext> iunitofworkkfirst)
        {
            _iunitofworkk = iunitofwork;
            _iunitofworkkfirst = iunitofworkkfirst;
        }

        public List<Employee> getemployees()
        {
            return _iunitofworkkfirst.Employeerepository.GetAll();
        }

        public void Add(Employee emp)
        {
            _iunitofworkk.Employeerepository.Add(emp);
            _iunitofworkk.Save();
        }
    }
}
