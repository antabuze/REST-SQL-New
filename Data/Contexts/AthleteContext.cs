using Microsoft.EntityFrameworkCore;
using REST_SQL_New.Models;

namespace REST_SQL_New.Data
{
    public class AthleteContext : DbContext
    {
        public AthleteContext(DbContextOptions<AthleteContext> opt) : base(opt)
        {

        }

        public DbSet<Athlete> Athletes { get; set; }
    }
}
