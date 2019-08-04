using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeApp.Models;
using System.Data;
using System.Data.Entity.Core.Objects;

namespace EmployeeApp.Controllers
{
    public class EmpController : Controller
    {
        EmployeeDBContext db = new EmployeeDBContext();

        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        public ActionResult SearchEmployees(Employee emp)
        {
            var EmployeeList = db.Employees.Where(e =>
                e.FirstName.Contains(emp.FirstName) || 
                e.LastName.Contains(emp.LastName) ||
                e.PhoneNumber.Contains(emp.PhoneNumber) ||
                e.PostalCode.Contains(emp.PostalCode) ||
                e.EmailID.Contains(emp.EmailID) ||
                e.StateName.Contains(emp.StateName)
            ).ToList();
            return View(EmployeeList);
        }

    }
}