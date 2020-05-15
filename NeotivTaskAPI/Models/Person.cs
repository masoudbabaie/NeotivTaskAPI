using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeotivTaskAPI.Models
{
    public class Person
    {        
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public int StatusID { get; set; }

        public virtual Status status { get; set; }
        public DateTime InfectedDate { get; set; }
        public Nullable<DateTime> NewStatusDate { get; set; }


    }
}