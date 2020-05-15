using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeotivTaskAPI.Models
{
    public class PeopleRepository
    {
       
        private static StatusRepository statusRepo = new StatusRepository();

        private static List<Person> lstPeople = new List<Person>();

       
        public PeopleRepository(List<Person> items)//Data will injected from a data source
        {
            lstPeople = items;
        }

        
        public Person GetByID(int ID)
        {
            return lstPeople.Where(p => p.ID == ID).FirstOrDefault();
        }
        public IEnumerable<Person> GetByDateStatus(DateTime StartDate, string status)
        {
            //Filter By StatusId has better performance
            return lstPeople.Where(p => p.InfectedDate >= StartDate && p.status.Title==status).ToList();
        }

        public Person Add(PersonViewModel item)
        {
            Person person = new Person
            {
                ID = lstPeople.Count + 1,
                Firstname = item.Firstname,
                LastName = item.LastName,
                InfectedDate = item.InfectedDate,
                NewStatusDate = item.NewStatusDate,
                StatusID = statusRepo.GetByTitle(item.StatusTitle).ID,
                status = statusRepo.GetByTitle(item.StatusTitle)
            };
            

            lstPeople.Add(person);
            return person;
        }

        public bool UpdateStatus(int ID, string StatusTitle)
        {
            Person person = GetByID(ID);
            if (person!=null)
            {
                person.StatusID = statusRepo.GetByTitle(StatusTitle).ID;
                return true;

            }
            else
            {
                return false;
            }
            
        }
    }
}