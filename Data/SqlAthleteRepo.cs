using REST_SQL_New.Models;
using System.Collections.Generic;
using System.Linq;

namespace REST_SQL_New.Data
{
    public class SqlAthleteRepo : IAthleteRepo
    {
        private readonly AthleteContext athlete_context;
        public SqlAthleteRepo(AthleteContext context)
        {
            athlete_context = context;
        }

        // **** Athletes ****
        public IEnumerable<Athlete> GetAllAthletes()
        {
            return athlete_context.Athletes.ToList();
        }

        public Athlete GetAthleteById(int id)
        {
            return athlete_context.Athletes.FirstOrDefault(p => p.ID == id);
        }
    }
}

