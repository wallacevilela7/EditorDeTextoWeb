using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EditorTexto.Models;
using EditorTexto.Data;

namespace EditorTexto.Controllers;

public class HomeController : Controller
{

    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View();
    }
}
