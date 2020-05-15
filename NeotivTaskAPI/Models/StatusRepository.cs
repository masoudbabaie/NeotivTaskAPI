using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeotivTaskAPI.Models
{
    public class StatusRepository
    {
        private static StatusRepository repo = new StatusRepository();

        public static StatusRepository Curent
        {
            get { return repo; }
        }

        private List<Status> lstStatus = new List<Status>
        {
            new Status {ID = 1, Title = "infected"},
            new Status {ID = 2, Title = "recovered"},
            new Status {ID = 3, Title = "deceased"}

        };

        public Status GetByID(int ID)
        {
            return lstStatus.Where(p => p.ID == ID).FirstOrDefault();
        }
        public Status GetByTitle(string Title)
        {
            return lstStatus.Where(p => p.Title == Title).FirstOrDefault();
        }
    }
}