using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using WebApplication3.Data;

namespace WebApplication3.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            AplicationContext  context = new AplicationContext();
            var employee = context.Employees.ToList();
            return View(employee );
        }
    }
}
