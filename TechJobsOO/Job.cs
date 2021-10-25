using System;
using System.Collections.Generic;

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

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public void ReplaceEmptyStrings()
        {
            List<Object> jobData = new List<Object>();
            jobData.Add(Name);
            jobData.Add(EmployerName);
            jobData.Add(EmployerLocation);
            jobData.Add(JobType);
            jobData.Add(JobCoreCompetency);

            foreach(Object item in jobData){
                if(item.Value == "")
                {
                    item.Value = "Data not available"
                }
            }
        }

        public override string ToString()
        {
            ReplaceEmptyStrings();

            return $@" 
            ID: {Id}
            Name: {Name}
            Employer: {EmployerName}
            Location: {EmployerLocation}
            Position Type: {JobType}
            Core Competency: {JobCoreCompetency}
            "
        }
    }
}
