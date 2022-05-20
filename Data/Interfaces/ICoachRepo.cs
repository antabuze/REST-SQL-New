using REST_SQL_New.Models;
using System.Collections.Generic;

namespace REST_SQL_New.Data
{
    public interface ICoachRepo
    {
        // **** Coaches ****
        IEnumerable<Coach> GetAllCoaches();
        Coach GetCoachById(int id);
    }
}
