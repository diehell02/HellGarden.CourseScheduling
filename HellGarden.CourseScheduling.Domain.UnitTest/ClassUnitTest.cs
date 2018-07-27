using System;
using HellGarden.CourseScheduling.Domain.Entity;
using HellGarden.CourseScheduling.Domain.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HellGarden.CourseScheduling.Domain.UnitTest
{
    [TestClass]
    public class ClassUnitTest
    {
        [TestMethod]
        public void GetAvailableCourse()
        {
            var @class0 = new Class(1, "Class1", new Course[]
                {
                    new Course(1, "Chinese", 5, CourseType.Chinese),
                    new Course(2, "Math", 5, CourseType.Math),
                    new Course(3, "English", 5, CourseType.English)
                });

            Assert.IsNotNull(@class0.GetAvailableCourse());

            var @class1 = new Class(1, "Class1", new Course[]
                {
                    new Course(1, "Chinese", 0, CourseType.Chinese),
                });

            Assert.IsNull(@class1.GetAvailableCourse());

            var @class2 = new Class(1, "Class1", new Course[]
                {
                });

            Assert.IsNull(@class2.GetAvailableCourse());
        }
    }
}
