using Microsoft.AspNetCore.Mvc;

namespace EmployeesManagement.Controllers
{
public class EmployeesController : Controller
{
public IActionResult Index()
        {
            return View();
        }

public IActionResult Sobre()
        {
            return View();
        }
    }
}