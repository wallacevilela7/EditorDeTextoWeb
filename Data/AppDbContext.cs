using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EditorTexto.Models;
using Microsoft.EntityFrameworkCore;

namespace EditorTexto.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options){}

        public DbSet<Documento> Documentos { get; set; }
    }
}