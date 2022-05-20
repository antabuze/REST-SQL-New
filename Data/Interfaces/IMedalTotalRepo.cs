using REST_SQL_New.Models;
using System.Collections.Generic;

namespace REST_SQL_New.Data.Interfaces
{
    public interface IMedalTotalRepo
    {
        // **** Medal Totals ****
        IEnumerable<MedalTotal> GetAllMedalTotals();
        MedalTotal GetMedalTotalById(int id);
    }
}
