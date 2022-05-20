using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_SQL_New.Models
{
    public class Coach
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public DateTime? birth_date { get; set; }
        public string country { get; set; }
        public string discipline { get; set; }
        public string role { get; set; }
        public string event_type { get; set; }
        public string url { get; set; }


    }
}
