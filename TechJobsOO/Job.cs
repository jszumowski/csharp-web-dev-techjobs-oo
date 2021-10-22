using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employer, Location location, PositionType type, CoreCompetency core)
        {
            Name = name;
            EmployerName = employer;
            EmployerLocation = location;
            JobType = type;
            JobCoreCompetency = core;
        }
        // TODO: Generate Equals() and GetHashCode() methods.

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return "/n " +
                "ID: " + Id +
                "Name: " + Name +
                "Employer: " + EmployerName +
                "Loaction: " + EmployerLocation + 
                "Position Type: " + JobType + 
                "Core Competency: " + JobCoreCompetency +
                "/n";
        }
    }
}
