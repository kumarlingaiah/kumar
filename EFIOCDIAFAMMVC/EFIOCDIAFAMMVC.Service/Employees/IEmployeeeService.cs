using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFIOCDIAFAMMVC.Model;

namespace EFIOCDIAFAMMVC.Service.Employees
{
    public interface IEmployeeeService
    {
        List<Employee> getemployees();
        void Add(Employee emp);
    }
}
