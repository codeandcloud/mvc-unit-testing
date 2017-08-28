using StudentManager.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManager.Web.Controllers
{
    public class EmployeeController : Controller
    {

        #region "Local Variables and Declarations"

        private IRepository repository;

        #endregion

        #region "Constructor"

        public EmployeeController()
        {
            this.repository = new WorkingEmployeeRepository();
        }

        public EmployeeController(IRepository repository)
        {
            this.repository = repository;
        }

        #endregion

        #region "Action Methods"

        // GET: Employee
        public ViewResult Index()
        {
            var employees = repository.GetAll();
            return View(employees);
        }

        //[Route("~/employees/first-name/{name}")]
        public ViewResult FindByName(string name)
        {
            var employees = repository.GetAll();
            var result = employees
                .Where(e => e.FirstName == name)
                .ToList();
            return View(result);
        }

        #endregion

        #region "Private Methods"

        #endregion
    }
}