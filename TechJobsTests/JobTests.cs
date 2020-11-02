using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId_IDsDifferByOne_ReturnsTrue()
        {
            var job1 = new Job();
            var job2 = new Job();

            Assert.AreEqual(job1.Id, job2.Id, 1);
        }

        [TestMethod]
        public void TestJonConstrictorSetsAllFields_AllFieldsSet_ReturnsTrue()
        {
            var name = "Product tester";
            var employer = new Employer("Acme");
            var location = new Location("Desert");
            var quality = new PositionType("Quality control");
            var coreCompetency = new CoreCompetency("Persistence");

            var job1 = new Job(name, employer, location, quality, coreCompetency);

            Assert.AreEqual(name, job1.Name);
            Assert.AreEqual(employer, job1.EmployerName);
            Assert.AreEqual(location, job1.EmployerLocation);
            Assert.AreEqual(quality, job1.JobType);
            Assert.AreEqual(coreCompetency, job1.JobCoreCompetency);
        }

        [TestMethod]
        public void TestJobsForEquality_CheckForIdEquality_ReturnsFalse()
        {
            var job1 = new Job();
            var job2 = new Job();

            Assert.AreNotEqual(job1, job2);
        }

        [TestMethod]
        public void TestJobsEmptyLines_CheckForEmptyLines_ReturnTrue()
        {
            var name = "Product tester";
            var employer = new Employer("Acme");
            var location = new Location("Desert");
            var quality = new PositionType("Quality control");
            var coreCompetency = new CoreCompetency("Persistence");

            var job1 = new Job(name, employer, location, quality, coreCompetency);
            var testChar = '\n';

            Assert.AreEqual(testChar, job1.ToString()[0]);
            Assert.AreEqual(testChar, job1.ToString()[1]);
            Assert.AreEqual(testChar, job1.ToString()[job1.ToString().Length - 1]);
            Assert.AreEqual(testChar, job1.ToString()[job1.ToString().Length - 2]);
        }

        [TestMethod]
        public void TestJobsToStringMethod_CheckForToStringMethod_ReturnsTrue()
        {
            var name = "Product tester";
            var employer = new Employer("Acme");
            var location = new Location("Desert");
            var quality = new PositionType("Quality control");
            var coreCompetency = new CoreCompetency("Persistence");

            var job1 = new Job(name, employer, location, quality, coreCompetency);
            var testString = $"\n\nID: {job1.Id}\nName: Product tester\nEmployer: Acme\nLocation: Desert\nPosition Type: Quality control\nCore Competency: Persistence\n\n";

            Assert.AreEqual(testString, job1.ToString());
        }

        [TestMethod]
        public void TestJobsNullFields_CheckForNullFields_ReturnsTrue()
        {
            var name = "Product tester";
            var employer = new Employer("");
            var location = new Location("Desert");
            var type = new PositionType("");
            var coreCompetency = new CoreCompetency("Persistence");

            var job1 = new Job(name, employer, location, type, coreCompetency);
            var testString = $"\n\nID: {job1.Id}\nName: Product tester\nEmployer: Data not available\nLocation: Desert\nPosition Type: Data not available\nCore Competency: Persistence\n\n";

            Assert.AreEqual(testString, job1.ToString());
        }

        [TestMethod]
        public void TestJobsEmptyLines_CheckForAllEmptyFields_ReturnTrue()
        {
            var name = "";
            var employer = new Employer("");
            var location = new Location("");
            var type = new PositionType("");
            var coreCompetency = new CoreCompetency("");

            var job1 = new Job(name, employer, location, type, coreCompetency);
            string testString = "\n\nOOPS! This job does not seem to exist.\n\n";

            Assert.AreEqual(testString, job1.ToString());
        }
    }
}
