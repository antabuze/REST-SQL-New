using Microsoft.EntityFrameworkCore;
using REST_SQL_New.Models;

namespace REST_SQL_New.Data
{
    public class MedalContext : DbContext
    {
        public MedalContext(DbContextOptions<MedalContext> opt) : base(opt)
        {

        }

        public DbSet<Medal> Medals { get; set; }
    }
}
