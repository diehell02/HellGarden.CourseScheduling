using HellGarden.CourseScheduling.Domain.Entity;
using HellGarden.CourseScheduling.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.DataAccess.Repository.Test
{
    public class TestLessonRepository : LessonRepository
    {
        public override void Add(Lesson @class)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Lesson @class)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Lesson> Get()
        {
            return new List<Lesson>()
            {
                new Lesson(11, 1, ""),
                new Lesson(12, 1, ""),
                new Lesson(13, 1, ""),
                new Lesson(14, 1, ""),
                new Lesson(15, 1, ""),
                new Lesson(16, 1, ""),
                new Lesson(17, 1, ""),
                new Lesson(18, 1, ""),
                new Lesson(19, 1, ""),
                new Lesson(21, 2, ""),
                new Lesson(22, 2, ""),
                new Lesson(23, 2, ""),
                new Lesson(24, 2, ""),
                new Lesson(25, 2, ""),
                new Lesson(26, 2, ""),
                new Lesson(27, 2, ""),
                new Lesson(28, 2, ""),
                new Lesson(29, 2, ""),
                new Lesson(31, 3, ""),
                new Lesson(32, 3, ""),
                new Lesson(33, 3, ""),
                new Lesson(34, 3, ""),
                new Lesson(35, 3, ""),
                new Lesson(36, 3, ""),
                new Lesson(37, 3, ""),
                new Lesson(38, 3, ""),
                new Lesson(39, 3, ""),
                new Lesson(41, 4, ""),
                new Lesson(42, 4, ""),
                new Lesson(43, 4, ""),
                new Lesson(44, 4, ""),
                new Lesson(45, 4, ""),
                new Lesson(46, 4, ""),
                new Lesson(47, 4, ""),
                new Lesson(48, 4, ""),
                new Lesson(49, 4, ""),
                new Lesson(51, 5, ""),
                new Lesson(52, 5, ""),
                new Lesson(53, 5, ""),
                new Lesson(54, 5, ""),
                new Lesson(55, 5, ""),
                new Lesson(56, 5, ""),
                new Lesson(57, 5, ""),
                new Lesson(58, 5, ""),
                new Lesson(59, 5, ""),
            };
        }
    }
}
