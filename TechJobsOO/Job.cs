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

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            this.Name = name;
            this.EmployerName = employerName;
            this.EmployerLocation = employerLocation;
            this.JobType = jobType;
            this.JobCoreCompetency = jobCoreCompetency;
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

        public override string ToString()
        {
            string jobString = "";
            var name = Name;
            var employer = EmployerName.Value;
            var location = EmployerLocation.Value;
            var type = JobType.Value;
            var competency = JobCoreCompetency.Value;


            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(employer) && string.IsNullOrEmpty(location) && string.IsNullOrEmpty(type) && string.IsNullOrEmpty(competency))
            {
                jobString = "\n\nOOPS! This job does not seem to exist.\n\n";
            }
            else if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(employer) || string.IsNullOrEmpty(location) || string.IsNullOrEmpty(type) || string.IsNullOrEmpty(competency))
            {
                string nullMessage = "Data not available";

                if (string.IsNullOrEmpty(name))
                {
                    name = nullMessage;
                }

                if (string.IsNullOrEmpty(employer))
                {
                    employer = nullMessage;
                }

                if (string.IsNullOrEmpty(location))
                {
                    location = nullMessage;
                }

                if (string.IsNullOrEmpty(type))
                {
                    type = nullMessage;
                }

                if (string.IsNullOrEmpty(competency))
                {
                    competency = nullMessage;
                }

                jobString = $"\n\nID: {this.Id}\nName: {name}\nEmployer: {employer}\nLocation: {location}\nPosition Type: {type}\nCore Competency: {competency}\n\n";
            }
            else
            {
                jobString = $"\n\nID: {this.Id}\nName: {name}\nEmployer: {employer}\nLocation: {location}\nPosition Type: {type}\nCore Competency: {competency}\n\n";
            }

            
            return jobString;
        }
    }
}
