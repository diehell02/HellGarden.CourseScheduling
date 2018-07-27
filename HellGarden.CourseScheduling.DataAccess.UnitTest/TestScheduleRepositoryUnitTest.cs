using System;
using HellGarden.CourseScheduling.DataAccess.Repository.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HellGarden.CourseScheduling.DataAccess.UnitTest
{
    [TestClass]
    public class TestScheduleRepositoryUnitTest
    {
        [TestMethod]
        public void GetSchedules()
        {
            var testScheduleRepository = new TestScheduleRepository();

            Assert.IsNotNull(testScheduleRepository.GetSchedules());
        }
    }
}
