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

    public IActionResult CriarDocumento(){
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CriarDocumento(Documento docRec){
        if(ModelState.IsValid){
            _context.Add(docRec);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        else 
        {
            return View(docRec);
        }
    }

    public async Task<IActionResult> EditarDocumento(int id){
        var doc = await _context.Documentos.FirstOrDefaultAsync(x => x.Id == id);
        return View(doc);
    }
}
