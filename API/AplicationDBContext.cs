using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public class AplicationDBContext: DbContext
    {
        public DbSet<Profesores> Profesores { get; set; }

        public DbSet<Estudiante> Estudiante{ get; set; }

        public AplicationDBContext(DbContextOptions<AplicationDBContext> options): base(options)
        {

        }

    }
}
