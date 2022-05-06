using System;
using System.Reflection;

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

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
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
            if (this.Name == null && this.EmployerName == null && this.EmployerLocation == null && this.JobType == null && this.JobCoreCompetency == null)
            {
                return "OOPS! This job does not seem to exist.";
            }

            string stringId = this.Id.ToString();
            string stringName = this.Name;
            string stringEmployerName = this.EmployerName.ToString();
            string stringEmployerLocation = this.EmployerLocation.ToString();
            string stringJobType = this.JobType.ToString();
            string stringJobCoreCompetency = this.JobCoreCompetency.ToString();

            if (stringId == "") { stringId = "Data not available"; }
            if (stringName == "") { stringName = "Data not available"; }
            if (stringEmployerName == "") { stringEmployerName = "Data not available"; }
            if (stringEmployerLocation == "") { stringEmployerLocation = "Data not available"; }
            if (stringJobType == "") { stringJobType = "Data not available"; }
            if (stringJobCoreCompetency == "") { stringJobCoreCompetency = "Data not available"; }

            //string[] strings = { stringId, stringEmployerLocation,
            //                     stringName, stringEmployerName,
            //                     stringJobType, stringJobCoreCompetency };

            //for (int i = 0; i < strings.Length; i++)
            //{
            //    if (strings[i] == "" || strings[i] == null) { strings[i] = "Data not available"; }
            //}

            return
                $"\nID: {stringId}\n" +
                $"Name: {stringName}\n" +
                $"Employer: {stringEmployerName}\n" +
                $"Location: {stringEmployerLocation}\n" +
                $"Position Type: {stringJobType}\n" +
                $"Core Competency: {stringJobCoreCompetency}\n";
        }
    }
}
