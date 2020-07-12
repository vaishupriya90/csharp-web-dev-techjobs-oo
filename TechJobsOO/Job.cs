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
            

            if(this.Id!=0 && Name.Equals(null) && EmployerName.Equals(null) && EmployerLocation.Equals(null) && JobType.Equals(null) && JobCoreCompetency.Equals(null))
            {
                return "OOPS! This job does not seem to exist.";
            }
            //if (this.Id == 0)
            //   output += "\nID: " + dna;
            if (this.Id == 0)
                tempId = dna;
            else
                tempId = "" + Id;
               
            if (this.EmployerName.Equals(null) || this.EmployerName.Value.Equals(""))
            {
                //output += "Employer Name: " + dna;
                EmployerName.Value = dna;
            }
            if (this.EmployerLocation.Equals(null) || this.EmployerLocation.Value.Equals(""))
            {
                //output += "Employer Location: " + dna;
                EmployerLocation.Value = dna;
            }
            if(this.JobType.Equals(null)|| this.JobType.Value.Equals(""))
            {
                //output += "Position type: " + dna;
                JobType.Value = dna;
            }
            if (this.JobCoreCompetency.Equals(null) || this.JobCoreCompetency.Value.Equals(""))
            {
                //output += "Core Competency : " + dna;
                JobCoreCompetency.Value = dna;
            }
            if (Name.Equals(""))
            {
                Name = dna;
             }
            output = "ID: " + tempId + "\nName: " + Name + "\nEmployer: " + EmployerName.Value + "\nLocation: "
               + EmployerLocation.Value + "\nPosition Type: " + JobType.Value + "\nCore Compentency: " + JobCoreCompetency.Value;
            
            return output;
        }
    }
}


