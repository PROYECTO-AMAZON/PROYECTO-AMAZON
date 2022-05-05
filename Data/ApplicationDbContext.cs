using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PROYECTO_AMAZON.Models;

namespace PROYECTO_AMAZON.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ALUMNO> ALUMNOs { get; set; }
        public ApplicationDbContext(DbContextOptions dco) : base(dco) {
            
        }
    }
}