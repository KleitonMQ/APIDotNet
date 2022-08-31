using Microsoft.EntityFrameworkCore;
using src.Models;
namespace src.Persistence;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
        
    }
    public DbSet<Pessoa> pessoas { get; set; }
    public DbSet<Contrato> contratos { get; set; }

    protected void OnModelCreating(ModelBuilder builder){

    }
}