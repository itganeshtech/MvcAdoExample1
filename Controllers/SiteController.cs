using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcAdoExample1.Models;
using MvcAdoExample1.ViewModels;

namespace MvcAdoExample1.Controllers
{
    public class SiteController : Controller
    {
        public IActionResult Index()
        {
            StudentViewModel svm = new StudentViewModel();
            List<Student> students = svm.GetAllStudents();
            return View(students);
        }
    }
}
