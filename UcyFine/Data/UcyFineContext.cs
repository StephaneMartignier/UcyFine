using Microsoft.EntityFrameworkCore;
using UcyFine.Models;

namespace UcyFine.Data
{
    public class UcyFineContext : DbContext
    {
        public UcyFineContext(DbContextOptions<UcyFineContext> options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Fine> Fines { get; set; }
        public DbSet<PlayerFine> PlayerFines { get; set; }
    }
}
