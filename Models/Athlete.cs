using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace REST_SQL_New.Models
{
    public class Athlete
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string name { get; set; }
        public string short_name { get; set; }
        public string gender { get; set; }
        public DateTime? birth_date { get; set; }
        public string birth_place { get; set; }
        public string birth_country { get; set; }    
        public string country { get; set; } 
        public string country_code { get; set; } 
        public string discipline { get; set; }  
        public string discipline_code { get; set; }  
        public string residence_place { get; set; }
        public string residence_country { get; set; }    
        public string height_m_ft { get; set; }
        public string url { get; set; }

    }
}
