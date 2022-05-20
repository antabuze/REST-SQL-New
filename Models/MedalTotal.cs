using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_SQL_New.Models 
{ 
    public class MedalTotal
    {
        public Byte ID { get; set; }
        public Byte Rank { get; set; }
        public string Country { get; set; }
        public Byte Gold { get; set; }
        public Byte Silver { get; set; }
        public Byte Bronze { get; set; }
        public Byte Total { get; set; }
        public Byte Order_by_Total { get; set; }
        public string Country_Code { get; set; }

    }
}
