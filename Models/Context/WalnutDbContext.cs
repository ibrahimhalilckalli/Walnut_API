using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Walnut_API.Models.Context
{
    public class WalnutDbContext : DbContext
    {
        public WalnutDbContext(DbContextOptions<WalnutDbContext> options) : base(options)
        {

        }
        public DbSet<Licence> Licences { get; set; }
        public DbSet<Document> Documents { get; set; }

    }
}
