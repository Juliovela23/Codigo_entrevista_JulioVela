using Conteo_camaras.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conteo_camaras.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base (options)
        {

        }
        public DbSet<Conteo_Seguridad>Conteo_Seguridad { get; set; }
    }
}
