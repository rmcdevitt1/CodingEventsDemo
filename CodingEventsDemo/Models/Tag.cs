using System;
namespace CodingEventsDemo.Models
{
    public class Tag
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public Tag(string name)
        {
            Name = name;
        }

        public Tag()
        {
        }
    }
}