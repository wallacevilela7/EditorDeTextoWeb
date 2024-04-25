using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EditorTexto.Models;
using EditorTexto.Data;
using Microsoft.EntityFrameworkCore;

namespace EditorTexto.Controllers;

public class HomeController : Controller
{

    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var doc = await _context.Documentos.ToListAsync(); 
        return View(doc);
    }
}
