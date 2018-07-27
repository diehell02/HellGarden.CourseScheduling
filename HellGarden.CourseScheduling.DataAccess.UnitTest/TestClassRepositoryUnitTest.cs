using System;
using HellGarden.CourseScheduling.DataAccess.Repository.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HellGarden.CourseScheduling.DataAccess.UnitTest
{
    [TestClass]
    public class TestClassRepositoryUnitTest
    {
        [TestMethod]
        public void GetClasses()
        {
            var testClassRepository = new TestClassRepository();

            Assert.IsNotNull(testClassRepository.GetClasses());
        }
    }
}
