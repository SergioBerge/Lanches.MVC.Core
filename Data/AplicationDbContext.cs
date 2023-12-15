using Lanches.MVC.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Lanches.MVC.Core.Data
{
    public class AplicationDbContext :DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options ) : base(options)
        {
            
        }
        public DbSet<LanchesModels> Lanches { get; set; }
    }
}
