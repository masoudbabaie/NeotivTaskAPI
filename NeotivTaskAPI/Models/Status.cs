using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeotivTaskAPI.Models
{
    public partial class Status
    {
        public Status()
        {
            this.People = new HashSet<Person>();
        }
        public int ID { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}