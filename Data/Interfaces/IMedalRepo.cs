using REST_SQL_New.Models;
using System.Collections.Generic;

namespace REST_SQL_New.Data.Interfaces
{
    public interface IMedalRepo
    {
        // **** Medals ****
        IEnumerable<Medal> GetAllMedals();
        Medal GetMedalById(int id);
    }
}
