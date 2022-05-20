using Microsoft.EntityFrameworkCore;
using REST_SQL_New.Models;

namespace REST_SQL_New.Data
{
    public class MedalTotalContext : DbContext
    {
        public MedalTotalContext(DbContextOptions<MedalTotalContext> opt) : base(opt)
        {

        }

        public DbSet<MedalTotal> medals_total { get; set; }
    }
}
