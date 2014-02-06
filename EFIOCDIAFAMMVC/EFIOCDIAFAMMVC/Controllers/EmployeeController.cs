using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFIOCDIAFAMMVC.Data.Infrastructure;
using EFIOCDIAFAMMVC.Model;
using EFIOCDIAFAMMVC.Models;
using AutoMapper;
using EFIOCDIAFAMMVC.Data.UnitOfWork;
using EFIOCDIAFAMMVC.Service.Employees;


namespace EFIOCDIAFAMMVC.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        //private Repository<Employee> _employeeRepository = new Repository<Employee>();
        //private IRepository<Employee> _iRepository;
        //public EmployeeController(IRepository<Employee> iRepository)
        //{
        //    _iRepository = iRepository;
        //}

        private IEmployeeeService _iemployeeservice;

        public EmployeeController(IEmployeeeService iemployeeservice)
        {
            _iemployeeservice = iemployeeservice;
        }

        public ActionResult Index()
        {
            // var employeesList = _iRepository.GetAll();             
            //_iunitofwork.
            // var employeeModelList = Mapper.Map<List<Employee>, List<EmployeeModel>>(employeesList);
            //return View(employeeModelList);

            //var employeelist = _iunitofwork.Employeerepository.GetAll();
            //var employeeModelList = Mapper.Map<List<Employee>, List<EmployeeModel>>(employeelist);
            //return View(employeeModelList);

            var employeelist = _iemployeeservice.getemployees();
            var employeeModelList = Mapper.Map<List<Employee>, List<EmployeeModel>>(employeelist);
            return View(employeeModelList);
        }

        public ActionResult Create()
        {
            var model = new EmployeeModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            if (ModelState.IsValid)
            {
                if (emp == null)
                    return View(emp);
                var employee = Mapper.Map<EmployeeModel, Employee>(emp);
                //_iRepository.Add(employee);
                //_iunitofwork.Employeerepository.Add(employee);
                _iemployeeservice.Add(employee);
                return RedirectToAction("Index");
            }
            return View(emp);
        }
    }
}
