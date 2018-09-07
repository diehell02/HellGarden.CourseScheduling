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
                    new Course(1, "Chinese", 6, CourseType.Chinese),
                    new Course(9, "English", 6, CourseType.English),
                    new Course(17, "Math", 7, CourseType.Math),
                    new Course(34, "Physics", 6, CourseType.Physics),
                    new Course(40, "Chemistry", 5, CourseType.Chemistry),
                    new Course(46, "Biology", 4, CourseType.Biology),
                    new Course(50, "Sports", 2, CourseType.Sports),
                    new Course(0, "Study", 7, CourseType.Study),
                    new Course(0, "Listening", 1, CourseType.Listening),
                    new Course(0, "Meeting", 1, CourseType.Meeting),
                }),
                new Class(2, "Class2", new Course[]
                {
                    new Course(2, "Chinese", 6, CourseType.Chinese),
                    new Course(10, "English", 6, CourseType.English),
                    new Course(18, "Math", 7, CourseType.Math),
                    new Course(35, "Physics", 6, CourseType.Physics),
                    new Course(41, "Chemistry", 5, CourseType.Chemistry),
                    new Course(47, "Biology", 4, CourseType.Biology),
                    new Course(50, "Sports", 2, CourseType.Sports),
                    new Course(0, "Study", 7, CourseType.Study),
                    new Course(0, "Listening", 1, CourseType.Listening),
                    new Course(0, "Meeting", 1, CourseType.Meeting),
                }),
                new Class(3, "Class3", new Course[]
                {
                    new Course(3, "Chinese", 6, CourseType.Chinese),
                    new Course(10, "English", 6, CourseType.English),
                    new Course(18, "Math", 7, CourseType.Math),
                    new Course(36, "Physics", 6, CourseType.Physics),
                    new Course(40, "Chemistry", 5, CourseType.Chemistry),
                    new Course(46, "Biology", 4, CourseType.Biology),
                    new Course(50, "Sports", 2, CourseType.Sports),
                    new Course(0, "Study", 7, CourseType.Study),
                    new Course(0, "Listening", 1, CourseType.Listening),
                    new Course(0, "Meeting", 1, CourseType.Meeting),
                }),
                new Class(4, "Class4", new Course[]
                {
                    new Course(4, "Chinese", 6, CourseType.Chinese),
                    new Course(11, "English", 6, CourseType.English),
                    new Course(17, "Math", 7, CourseType.Math),
                    new Course(35, "Physics", 6, CourseType.Physics),
                    new Course(42, "Chemistry", 5, CourseType.Chemistry),
                    new Course(47, "Biology", 4, CourseType.Biology),
                    new Course(50, "Sports", 2, CourseType.Sports),
                    new Course(0, "Study", 7, CourseType.Study),
                    new Course(0, "Listening", 1, CourseType.Listening),
                    new Course(0, "Meeting", 1, CourseType.Meeting),
                }),
                new Class(5, "Class5", new Course[]
                {
                    new Course(2, "Chinese", 6, CourseType.Chinese),
                    new Course(9, "English", 6, CourseType.English),
                    new Course(19, "Math", 7, CourseType.Math),
                    new Course(36, "Physics", 6, CourseType.Physics),
                    new Course(41, "Chemistry", 5, CourseType.Chemistry),
                    new Course(47, "Biology", 4, CourseType.Biology),
                    new Course(50, "Sports", 2, CourseType.Sports),
                    new Course(0, "Study", 7, CourseType.Study),
                    new Course(0, "Listening", 1, CourseType.Listening),
                    new Course(0, "Meeting", 1, CourseType.Meeting),
                }),
                new Class(6, "Class6", new Course[]
                {
                    new Course(1, "Chinese", 6, CourseType.Chinese),
                    new Course(12, "English", 6, CourseType.English),
                    new Course(20, "Math", 7, CourseType.Math),
                    new Course(26, "Politics", 5, CourseType.Politics),
                    new Course(28, "History", 5, CourseType.History),
                    new Course(31, "Geography", 5, CourseType.Geography),
                    new Course(50, "Sports", 2, CourseType.Sports),
                    new Course(0, "Study", 7, CourseType.Study),
                    new Course(0, "Listening", 1, CourseType.Listening),
                    new Course(0, "Meeting", 1, CourseType.Meeting),
                }),
                new Class(7, "Class7", new Course[]
                {
                    new Course(3, "Chinese", 6, CourseType.Chinese),
                    new Course(12, "English", 6, CourseType.English),
                    new Course(21, "Math", 7, CourseType.Math),
                    new Course(26, "Politics", 5, CourseType.Politics),
                    new Course(29, "History", 5, CourseType.History),
                    new Course(32, "Geography", 5, CourseType.Geography),
                    new Course(50, "Sports", 2, CourseType.Sports),
                    new Course(0, "Study", 7, CourseType.Study),
                    new Course(0, "Listening", 1, CourseType.Listening),
                    new Course(0, "Meeting", 1, CourseType.Meeting),
                }),
                new Class(8, "Class8", new Course[]
                {
                    new Course(5, "Chinese", 6, CourseType.Chinese),
                    new Course(13, "English", 6, CourseType.English),
                    new Course(22, "Math", 7, CourseType.Math),
                    new Course(37, "Physics", 6, CourseType.Physics),
                    new Course(43, "Chemistry", 5, CourseType.Chemistry),
                    new Course(48, "Biology", 4, CourseType.Biology),
                    new Course(51, "Sports", 2, CourseType.Sports),
                    new Course(0, "Study", 7, CourseType.Study),
                    new Course(0, "Listening", 1, CourseType.Listening),
                    new Course(0, "Meeting", 1, CourseType.Meeting),
                }),
                new Class(9, "Class9", new Course[]
                {
                    new Course(6, "Chinese", 6, CourseType.Chinese),
                    new Course(14, "English", 6, CourseType.English),
                    new Course(23, "Math", 7, CourseType.Math),
                    new Course(38, "Physics", 6, CourseType.Physics),
                    new Course(43, "Chemistry", 5, CourseType.Chemistry),
                    new Course(48, "Biology", 4, CourseType.Biology),
                    new Course(52, "Sports", 2, CourseType.Sports),
                    new Course(0, "Study", 7, CourseType.Study),
                    new Course(0, "Listening", 1, CourseType.Listening),
                    new Course(0, "Meeting", 1, CourseType.Meeting),
                }),
                new Class(10, "Class10", new Course[]
                {
                    new Course(6, "Chinese", 6, CourseType.Chinese),
                    new Course(14, "English", 6, CourseType.English),
                    new Course(24, "Math", 7, CourseType.Math),
                    new Course(37, "Physics", 6, CourseType.Physics),
                    new Course(44, "Chemistry", 5, CourseType.Chemistry),
                    new Course(49, "Biology", 4, CourseType.Biology),
                    new Course(51, "Sports", 2, CourseType.Sports),
                    new Course(0, "Study", 7, CourseType.Study),
                    new Course(0, "Listening", 1, CourseType.Listening),
                    new Course(0, "Meeting", 1, CourseType.Meeting),
                }),
                new Class(11, "Class11", new Course[]
                {
                    new Course(7, "Chinese", 6, CourseType.Chinese),
                    new Course(15, "English", 6, CourseType.English),
                    new Course(19, "Math", 7, CourseType.Math),
                    new Course(39, "Physics", 6, CourseType.Physics),
                    new Course(44, "Chemistry", 5, CourseType.Chemistry),
                    new Course(49, "Biology", 4, CourseType.Biology),
                    new Course(52, "Sports", 2, CourseType.Sports),
                    new Course(0, "Study", 7, CourseType.Study),
                    new Course(0, "Listening", 1, CourseType.Listening),
                    new Course(0, "Meeting", 1, CourseType.Meeting),
                }),
                new Class(12, "Class12", new Course[]
                {
                    new Course(5, "Chinese", 6, CourseType.Chinese),
                    new Course(15, "English", 6, CourseType.English),
                    new Course(25, "Math", 7, CourseType.Math),
                    new Course(39, "Physics", 6, CourseType.Physics),
                    new Course(45, "Chemistry", 5, CourseType.Chemistry),
                    new Course(49, "Biology", 4, CourseType.Biology),
                    new Course(52, "Sports", 2, CourseType.Sports),
                    new Course(0, "Study", 7, CourseType.Study),
                    new Course(0, "Listening", 1, CourseType.Listening),
                    new Course(0, "Meeting", 1, CourseType.Meeting),
                }),
                new Class(13, "Class13", new Course[]
                {
                    new Course(8, "Chinese", 6, CourseType.Chinese),
                    new Course(16, "English", 6, CourseType.English),
                    new Course(22, "Math", 7, CourseType.Math),
                    new Course(27, "Politics", 5, CourseType.Politics),
                    new Course(30, "History", 5, CourseType.History),
                    new Course(33, "Geography", 5, CourseType.Geography),
                    new Course(51, "Sports", 2, CourseType.Sports),
                    new Course(0, "Study", 7, CourseType.Study),
                    new Course(0, "Listening", 1, CourseType.Listening),
                    new Course(0, "Meeting", 1, CourseType.Meeting),
                }),
                new Class(14, "Class14", new Course[]
                {
                    new Course(7, "Chinese", 6, CourseType.Chinese),
                    new Course(16, "English", 6, CourseType.English),
                    new Course(23, "Math", 7, CourseType.Math),
                    new Course(27, "Politics", 5, CourseType.Politics),
                    new Course(30, "History", 5, CourseType.History),
                    new Course(33, "Geography", 5, CourseType.Geography),
                    new Course(52, "Sports", 2, CourseType.Sports),
                    new Course(0, "Study", 7, CourseType.Study),
                    new Course(0, "Listening", 1, CourseType.Listening),
                    new Course(0, "Meeting", 1, CourseType.Meeting),
                }),
            };
        }
    }
}
