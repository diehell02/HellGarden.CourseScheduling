using System;
using HellGarden.CourseScheduling.DataAccess.Repository.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HellGarden.CourseScheduling.DataAccess.UnitTest
{
    [TestClass]
    public class TestLessonRepositoryUnitTest
    {
        [TestMethod]
        public void GetLessons()
        {
            var testLessonRepository = new TestLessonRepository();

            Assert.IsNotNull(testLessonRepository.GetLessons());
        }
    }
}
