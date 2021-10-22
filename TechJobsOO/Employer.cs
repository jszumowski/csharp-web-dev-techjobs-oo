using System;
namespace TechJobsOO
{
    public class Employer : JobField
    {
        public Employer()
        {
            Id = nextId;
            nextId++;
        }
        public Employer(string value)
        {
            Value = value;
        }
    }
}
