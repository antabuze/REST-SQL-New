using Microsoft.EntityFrameworkCore;
using REST_SQL_New.Models;

namespace REST_SQL_New.Data
{
    public class CoachContext : DbContext
    {
        public CoachContext(DbContextOptions<CoachContext> opt) : base(opt)
        {

        }

        public DbSet<Coach> Coaches { get; set; }
    }
}
