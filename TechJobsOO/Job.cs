using System;

namespace TechJobsOO
{
    public class Job 
    {
        public int Id { get; set; }
        public static int nextId = 1;

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

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency):this()
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
            string dna = "Data not available";
            string tempId = "";
            string output="";

            
        
            if(this.Id != 0 && this.Name==null && this.EmployerName==null && this.EmployerLocation==null && this.JobType==null && this.JobCoreCompetency==null)
            {
                return "OOPS! This job does not seem to exist.";
            }
            
            if (this.Id == 0)
                tempId = dna;
            else
                tempId = "" + Id;
               
            if (this.EmployerName.Value.Equals(""))
            {
                EmployerName.Value = dna;
            }
            if (this.EmployerLocation.Value.Equals(""))
            {
                EmployerLocation.Value = dna;
            }
            if(this.JobType.Value.Equals(""))
            {
                JobType.Value = dna;
            }
            if (this.JobCoreCompetency.Value.Equals(""))
            {
                JobCoreCompetency.Value = dna;
            }
            if (Name.Equals(""))
            {
                Name = dna;
             }
            output = "\nID: " + tempId + "\nName: " + Name + "\nEmployer: " + EmployerName.Value + "\nLocation: "
               + EmployerLocation.Value + "\nPosition Type: " + JobType.Value + "\nCore Compentency: " + JobCoreCompetency.Value+"\n";
            
            return output;
        }
    }
}


