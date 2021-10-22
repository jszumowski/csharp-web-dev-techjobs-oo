using System;
namespace TechJobsOO
{
    public class Location : JobField
    {
        public Location()
        {
            Id = nextId;
            nextId++;
        }
        public Location(string value)
        {
            Value = value;
        }
    }
}
