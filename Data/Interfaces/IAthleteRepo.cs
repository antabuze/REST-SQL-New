using REST_SQL_New.Models;
using System.Collections.Generic;

namespace REST_SQL_New.Data
{
    public interface IAthleteRepo
    {
        // **** Athletes ****
        IEnumerable<Athlete> GetAllAthletes();
        Athlete GetAthleteById(int id);
    }
}
