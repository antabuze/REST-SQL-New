using REST_SQL_New.Data.Interfaces;
using REST_SQL_New.Models;
using System.Collections.Generic;
using System.Linq;

namespace REST_SQL_New.Data
{
    public class SqlMedalRepo : IMedalRepo
    {
        private readonly MedalContext medal_context;
        public SqlMedalRepo(MedalContext context)
        {
            medal_context = context;
        }

        // **** Medals ****
        public IEnumerable<Medal> GetAllMedals()
        {
            return medal_context.Medals.ToList();
        }
        public Medal GetMedalById(int id)
        {
            return medal_context.Medals.FirstOrDefault(p => p.ID == id);
        }
    }
}
