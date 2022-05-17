using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PROYECTO_AMAZON.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<ALUMNO> ALUMNOs { get; set; }
    public DbSet<CARRERA> CARRERAs { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

}
