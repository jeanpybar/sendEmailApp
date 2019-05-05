using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace angularapp.Models
    {
    public class EmailSearchViewModel
        {
        public string ToEmail { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Subject { get; set; }

        
        }
    }
