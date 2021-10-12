using System;
namespace CodingEventsDemo.Models
{
    public class EventCategory //this class represents data that will be stored in our database.//
    {

        public string Name { get; set; }

        public int Id { get; set; }

        //is this the no arg constructor??//
        public EventCategory()
        {
        }

        public EventCategory(string name)
        {
            Name = name;
        }
    }
}
