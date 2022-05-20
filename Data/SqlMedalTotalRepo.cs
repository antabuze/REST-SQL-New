using REST_SQL_New.Data.Interfaces;
using REST_SQL_New.Models;
using System.Collections.Generic;
using System.Linq;

namespace REST_SQL_New.Data
{
    public class SqlMedalTotalRepo : IMedalTotalRepo
    {
        private readonly MedalTotalContext medalTotal_context;
        public SqlMedalTotalRepo(MedalTotalContext context)
        {
            medalTotal_context = context;
        }

        // **** Medal Totals ****
        public IEnumerable<MedalTotal> GetAllMedalTotals()
        {
            return medalTotal_context.medals_total.ToList();
        }
        public MedalTotal GetMedalTotalById(int id)
        {
            return medalTotal_context.medals_total.FirstOrDefault(p => p.ID == id);
        }
    }
}
