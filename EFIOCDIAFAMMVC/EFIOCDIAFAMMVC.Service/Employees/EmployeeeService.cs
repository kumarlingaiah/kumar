using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFIOCDIAFAMMVC.Data.UnitOfWork;
using EFIOCDIAFAMMVC.Model;

namespace EFIOCDIAFAMMVC.Service.Employees
{
    public class EmployeeeService : IEmployeeeService
    {
        private IUnitOfWork _iunitofworkk;

        public EmployeeeService(IUnitOfWork iunitofwork)
        {
            _iunitofworkk = iunitofwork;
        }

        public List<Employee> getemployees()
        {
            return _iunitofworkk.Employeerepository.GetAll();
        }

        public void Add(Employee emp)
        {
            _iunitofworkk.Employeerepository.Add(emp);
        }
    }
}
