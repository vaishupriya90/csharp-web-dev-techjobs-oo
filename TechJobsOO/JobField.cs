using System;
namespace TechJobsOO
{
    public abstract class JobField
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public JobField()
        {
            this.Id = nextId;
            nextId++;
        }

        public JobField(string value) : this()
        {
            this.Value = value;
        }


    }
}
