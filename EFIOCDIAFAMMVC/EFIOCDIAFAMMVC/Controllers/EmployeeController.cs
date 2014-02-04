using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFIOCDIAFAMMVC.Data.Infrastructure;
using EFIOCDIAFAMMVC.Model;
using EFIOCDIAFAMMVC.Models;
using AutoMapper;
namespace EFIOCDIAFAMMVC.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        //private Repository<Employee> _employeeRepository = new Repository<Employee>();

        private IRepository<Employee> _iRepository;
        public EmployeeController(IRepository<Employee> iRepository)
        {
            _iRepository = iRepository;
        }

        public ActionResult Index()
        {
            var employeesList = _iRepository.GetAll();
            var employeeModelList = Mapper.Map<List<Employee>, List<EmployeeModel>>(employeesList);
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
                _iRepository.Add(employee);
                return RedirectToAction("Index");
            }
            return View(emp);
        }
    }
}
