using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId_IDsDifferByOne_ReturnsTrue()
        {
            var job1 = new TechJobsOO.Job();
            var job2 = new TechJobsOO.Job();

            Assert.AreEqual(job1.Id, job2.Id, 1);
        }

        [TestMethod]
        public void TestJonConstrictorSetsAllFields_AllFieldsSet_ReturnsTrue()
        {
            var name = "Product tester";
            var employer = new TechJobsOO.Employer("Acme");
            var location = new TechJobsOO.Location("Desert");
            var quality = new TechJobsOO.PositionType("Quality control");
            var coreCompetency = new TechJobsOO.CoreCompetency("Persistence");

            var job1 = new TechJobsOO.Job(name, employer, location, quality, coreCompetency);

            Assert.AreEqual(name, job1.Name);
            Assert.AreEqual(employer, job1.EmployerName);
            Assert.AreEqual(location, job1.EmployerLocation);
            Assert.AreEqual(quality, job1.JobType);
            Assert.AreEqual(coreCompetency, job1.JobCoreCompetency);
        }

        [TestMethod]
        public void TestJobsForEquality_CheckForId_ReturnsFalse()
        {
            var name = "Product tester";
            var employer = new TechJobsOO.Employer("Acme");
            var location = new TechJobsOO.Location("Desert");
            var quality = new TechJobsOO.PositionType("Quality control");
            var coreCompetency = new TechJobsOO.CoreCompetency("Persistence");

            var job1 = new TechJobsOO.Job(name, employer, location, quality, coreCompetency);
            var job2 = new TechJobsOO.Job(name, employer, location, quality, coreCompetency);

            Assert.AreNotEqual(job1.Id, job2.Id);
        }
    }
}
