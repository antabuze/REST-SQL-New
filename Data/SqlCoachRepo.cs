using REST_SQL_New.Models;
using System.Collections.Generic;
using System.Linq;

namespace REST_SQL_New.Data
{
    public class SqlCoachRepo : ICoachRepo
    {
        private readonly CoachContext coach_context;
        public SqlCoachRepo(CoachContext context)
        {
            coach_context = context;
        }
        
        // **** Coaches ****
        public IEnumerable<Coach> GetAllCoaches()
        {
            return coach_context.Coaches.ToList();
        }
        public Coach GetCoachById(int id)
        {
            return coach_context.Coaches.FirstOrDefault(p => p.ID == id);
        }
    }
}
