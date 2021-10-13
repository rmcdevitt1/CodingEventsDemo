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

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Event @event &&
                   Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
