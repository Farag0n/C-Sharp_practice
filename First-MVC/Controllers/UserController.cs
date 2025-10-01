using Microsoft.AspNetCore.Mvc;

namespace First_MVC.Controllers;

public class UserController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}