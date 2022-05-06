using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();

            Assert.AreEqual(job1.Id, job2.Id - 1);
            Assert.IsFalse(job1.Id == job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual(job1.Name, "Product tester");
            Assert.AreEqual(job1.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job1.JobType.Value, "Quality control");
            Assert.AreEqual(job1.EmployerName.Value, "ACME");
            Assert.AreEqual(job1.JobCoreCompetency.Value, "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreNotEqual(job1, job2);
        }

        [TestMethod]
        public void TestJobToString()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job();
            Job job3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));

            string job1Name = job1.ToString();
            string fullString1 = "\nID: 6\n" +
                                "Name: Product tester\n" +
                                "Employer: ACME\n" +
                                "Location: Desert\n" +
                                "Position Type: Quality control\n" +
                                "Core Competency: Persistence\n";

            string fullString2 = "\nID: 8\n" +
                                "Name: Ice cream tester\n" +
                                "Employer: Data not available\n" +
                                "Location: Home\n" +
                                "Position Type: UX\n" +
                                "Core Competency: Tasting ability\n";

            //Test that string begins and ends with a newline
            Assert.AreEqual(job1Name[0], job1Name[job1Name.Length - 1]);
            Assert.AreEqual(job1Name[0].ToString(), "\n");

            //Test that string should contain a label for each field
            Assert.AreEqual(fullString1, job1.ToString());

            //Test data not available for empty strings
            Assert.AreEqual(fullString2, job3.ToString());

            //Test that entries with only an Id return “OOPS! This job does not seem to exist.”
            Assert.AreEqual(("OOPS! This job does not seem to exist."), job2.ToString());

        }
    }
}
