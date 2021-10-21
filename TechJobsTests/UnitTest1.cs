using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TestProject1TechJobsTests
{
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job test_job_one = new Job();
            Job test_job_two = new Job();
            Assert.IsFalse(test_job_one.Id == test_job_two.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product tester", test_job.Name);
            Assert.AreEqual("ACME", test_job.EmployerName);
            Assert.AreEqual("Desert", test_job.EmployerLocation);
            Assert.AreEqual("Quality control", test_job.JobType);
            Assert.AreEqual("Persistence", test_job.JobCoreCompetency);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job test_job_one = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job test_job_two = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(test_job_one.Equals(test_job_two));
        }


    }
}
