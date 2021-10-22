using System;
namespace TechJobsOO
{
    public class CoreCompetency : JobField
    {
        public CoreCompetency()
        {
            Id = nextId;
            nextId++;
        }
        public CoreCompetency(string value)
        {
            Value = value;
        }
    }
}
