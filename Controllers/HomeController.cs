using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EditorTexto.Models;

namespace EditorTexto.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
}
