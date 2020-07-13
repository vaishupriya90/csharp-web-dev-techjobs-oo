using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;

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
            string name = "Product tester";
            Employer employerName = new Employer("ACME");
            Location employerLocation = new Location("Desert");
            PositionType jobType = new PositionType("Quality control");
            CoreCompetency jobCoreCompetency = new CoreCompetency("Persistence");

            Job newJob = new Job(name, employerName, employerLocation, jobType, jobCoreCompetency);

            Assert.AreEqual(newJob.EmployerName.Value, "ACME");
            Assert.AreEqual(newJob.EmployerLocation.Value, "Desert");
            Assert.AreEqual(newJob.JobType.Value, "Quality control");
            Assert.AreEqual(newJob.Name, "Product tester");
            Assert.AreEqual(newJob.JobCoreCompetency.Value, "Persistence");
            Assert.AreEqual(newJob.Id, 3);
        }
        [TestMethod]
        public void TestJobToStringContainsLabel()
        {
            string name = "Product tester";
            Employer employerName = new Employer("ACME");
            Location employerLocation = new Location("Desert");
            PositionType jobType = new PositionType("Quality control");
            CoreCompetency jobCoreCompetency = new CoreCompetency("Persistence");

            Job newJob1 = new Job(name, employerName, employerLocation, jobType, jobCoreCompetency);
            string actualOutput = newJob1.ToString();
            string expectedOutput = "\nID: 4" +
                    "\nName: Product tester" +
                    "\nEmployer: ACME" +
                    "\nLocation: Desert" +
                    "\nPosition Type: Quality control" +
                    "\nCore Compentency: Persistence\n";
            Assert.AreEqual(expectedOutput, actualOutput);

        }
        [TestMethod]
        public void TestJobToStringDataNotFound()
        {
            string name = "Product tester";
            Employer employerName = new Employer("");
            Location employerLocation = new Location("Desert");
            PositionType jobType = new PositionType("Quality control");
            CoreCompetency jobCoreCompetency = new CoreCompetency("Persistence");

            Job newJob2 = new Job(name, employerName, employerLocation, jobType, jobCoreCompetency);
            string actualOutput = newJob2.ToString();
            string expectedOutput = "\nID: 5" +
                    "\nName: Product tester" +
                    "\nEmployer: Data not available" +
                    "\nLocation: Desert" +
                    "\nPosition Type: Quality control" +
                    "\nCore Compentency: Persistence\n";
            Assert.AreEqual(expectedOutput, actualOutput);

        }
        [TestMethod]
        public void TestJobToStringJobNotExist()
        {
            Job newJob3 = new Job();
            string  expectedOutput = "OOPS! This job does not seem to exist.";
            string actualOutput = newJob3.ToString();
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
