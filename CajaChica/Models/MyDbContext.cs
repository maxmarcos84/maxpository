using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CajaChica.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {           

        }

        public DbSet<Persona> Persona { get; set; }
        public DbSet<Domicilio> Domicilio { get; set; } 
        public DbSet<Empleado> Empleado { get; set; }
    }
}
