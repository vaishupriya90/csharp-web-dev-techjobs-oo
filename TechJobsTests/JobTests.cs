using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();

            Assert.IsFalse(job1.Id == job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            string name = "Product tester-2";
            
            Employer employerName = new Employer();
            Location employerLocation = new Location("Desert");
            PositionType jobType = new PositionType("Quality control");
            CoreCompetency jobCoreCompetency = new CoreCompetency("Persistence");

            Job newJob = new Job(name, null, employerLocation, jobType, jobCoreCompetency,1);

            Assert.AreEqual(newJob.EmployerName.Value, "ACME");
            Assert.AreEqual(newJob.EmployerLocation.Value, "Desert");
            Assert.AreEqual(newJob.JobType.Value, "Quality control");
            Assert.AreEqual(newJob.Name, "Product tester");
            Assert.AreEqual(newJob.JobCoreCompetency.Value, "Persistence");
            Assert.AreEqual(newJob.Id, 3);


        }
    }
}
