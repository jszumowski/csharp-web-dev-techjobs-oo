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

        public Job(string name, Employer employer, Location location, PositionType type, CoreCompetency core) : this()
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
            List<String> jobData = new List<String>();
            jobData.Add(EmployerName.Value);
            jobData.Add(EmployerLocation.Value);
            jobData.Add(JobType.Value);
            jobData.Add(JobCoreCompetency.Value);

            for(int i = 0; i < jobData.Count; i++){
                if(jobData[i] == "")
                {
                    jobData[i] = "Data not available";
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
            ";
        }
    }
}
