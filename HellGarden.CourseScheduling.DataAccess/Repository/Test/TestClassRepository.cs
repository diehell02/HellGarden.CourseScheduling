using HellGarden.CourseScheduling.Domain.Entity;
using HellGarden.CourseScheduling.Domain.Repository;
using HellGarden.CourseScheduling.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.DataAccess.Repository.Test
{
    public class TestClassRepository : ClassRepository
    {
        public override IEnumerable<Class> GetClasses()
        {
            return new List<Class>()
            {
                new Class(1, "Class1", new Course[] 
                {
                    new Course(1, "Chinese", 5, CourseType.Chinese),
                    new Course(2, "Math", 5, CourseType.Math),
                    new Course(3, "English", 5, CourseType.English)
                }),
                new Class(2, "Class2", new Course[]
                {
                    new Course(1, "Chinese", 5, CourseType.Chinese),
                    new Course(2, "Math", 5, CourseType.Math),
                    new Course(3, "English", 5, CourseType.English)
                }),
            };
        }
    }
}
