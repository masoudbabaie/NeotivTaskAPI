using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeotivTaskAPI.Models
{
    public class PersonViewModel
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string StatusTitle { get; set; }        
        public DateTime InfectedDate { get; set; }
        public Nullable<DateTime> NewStatusDate { get; set; }
    }
}