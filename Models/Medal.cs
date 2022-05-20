using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_SQL_New.Models 
{ 
    public class Medal
    {
        public int ID { get; set; }
        public string medal_type { get; set; }
        public Byte medal_code { get; set; }
        public DateTime? medal_date { get; set; }
        public string athlete_short_name { get; set; }
        public string athlete_name { get; set; }
        public string athlete_sex { get; set; }
        public string athlete_link { get; set; }
        public string event_type { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
        public string discipline { get; set; }
        public string discipline_code { get; set; }

    }
}
