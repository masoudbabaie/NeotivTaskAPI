using NeotivTaskAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NeotivTaskAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );




            ////----------------- Seed ------------------
            //PeopleRepository repo = new PeopleRepository(
            //    new List<Person>
            //    {
            //        new Person {ID=1,Firstname="Masoud",LastName="Babaei",StatusID=1 ,InfectedDate=DateTime.Now, NewStatusDate=null,status= new Status {ID = 1, Title = "infected"}},
            //        new Person {ID=2,Firstname="Anne",LastName="Graeger",StatusID=2 ,InfectedDate=DateTime.Now, NewStatusDate=DateTime.Now.AddDays(1),status= new Status {ID = 2, Title = "recovered"}},
            //        new Person {ID=3,Firstname="John",LastName="Druidi",StatusID=3 ,InfectedDate=DateTime.Now, NewStatusDate=DateTime.Now.AddDays(1),status= new Status {ID = 3, Title = "deceased"}},
            //        new Person {ID=4,Firstname="Sara",LastName="Stoll",StatusID=1 ,InfectedDate=DateTime.Now, NewStatusDate=null,status= new Status {ID = 1, Title = "infected"}}
            //    });

        }
    }
}
