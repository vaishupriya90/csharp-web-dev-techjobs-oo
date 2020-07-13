using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;



namespace TechJobsTests
{
    
    [TestClass]
   
    public class JobTests
    {
        Job job1;
        Job job2;
        Job job3;
        Job job4;
        [TestInitialize]
        public void TestCreateObject()
        {
            job1 = new Job();
            job2 = new Job();
            job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            job4 = new Job("Product tester", new Employer(""), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        }
        [TestCleanup]
        public void TestCleanUp()
        {
            Job.nextId = 1;
        }

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }
        [TestMethod]
        public void TestSettingJobId()
        {        

            Assert.IsFalse(job1.Id == job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {


            Assert.AreEqual(job3.EmployerName.Value, "ACME");
            Assert.AreEqual(job3.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job3.JobType.Value, "Quality control");
            Assert.AreEqual(job3.Name, "Product tester");
            Assert.AreEqual(job3.JobCoreCompetency.Value, "Persistence");
            Assert.AreEqual(3,job3.Id);
        }
        [TestMethod]
        public void TestJobToStringContainsLabel()
        {
            string actualOutput = job3.ToString();
            string expectedOutput = "\nID: 3" +
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
            string actualOutput = job4.ToString();
            string expectedOutput = "\nID: 4" +
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
            string  expectedOutput = "OOPS! This job does not seem to exist.";
            string actualOutput = job1.ToString();
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
