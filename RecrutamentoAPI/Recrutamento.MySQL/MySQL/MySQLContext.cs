using Microsoft.EntityFrameworkCore;
using Recrutamento.Domain.Entities;

namespace Recrutamento.MySQL.MySQL;

public class MySQLContext : DbContext
{
    public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
    {
    }
    public DbSet<Candidato> Candidatos { get; set; }
    public DbSet<ProcessoSeletivo> ProcessoSeletivos { get; set; }
    public DbSet<Vaga> Vagas { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure your entity mappings here
        // For example:
        // modelBuilder.Entity<YourEntity>().ToTable("YourTableName");
    }
}