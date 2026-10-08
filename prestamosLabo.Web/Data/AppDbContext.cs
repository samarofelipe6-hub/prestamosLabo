using Microsoft.EntityFrameworkCore;
using prestamosLabo.Web.Models;

namespace prestamosLabo.Web.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Equipo> Equipos => Set<Equipo>();
}