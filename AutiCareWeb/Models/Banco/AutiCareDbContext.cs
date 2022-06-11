using Microsoft.EntityFrameworkCore;

namespace AutiCareWeb.Models.Banco
{
    public class AutiCareDbContext : DbContext
    {
        public AutiCareDbContext(DbContextOptions options) : base(options) { }
        public DbSet<TableDiagnostico> TableDiagnostico { get; set; }
    }
}
