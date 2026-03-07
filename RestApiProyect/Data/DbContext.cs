using Microsoft.EntityFrameworkCore;
using RestApiProyect.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Tareas> Tareas => Set<Tareas>();
}