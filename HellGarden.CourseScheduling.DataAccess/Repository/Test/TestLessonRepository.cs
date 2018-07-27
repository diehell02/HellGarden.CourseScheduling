using HellGarden.CourseScheduling.Domain.Entity;
using HellGarden.CourseScheduling.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.DataAccess.Repository.Test
{
    public class TestLessonRepository : LessonRepository
    {
        public override IEnumerable<Lesson> GetLessons()
        {
            return new List<Lesson>()
            {
                new Lesson(1, 1, "08:00:00", "09:00:00"),
                new Lesson(2, 1, "10:00:00", "11:00:00"),
                new Lesson(3, 1, "14:00:00", "15:00:00"),
                new Lesson(4, 2, "08:00:00", "09:00:00"),
                new Lesson(5, 2, "10:00:00", "11:00:00"),
                new Lesson(6, 2, "14:00:00", "15:00:00"),
                new Lesson(7, 3, "08:00:00", "09:00:00"),
                new Lesson(8, 3, "10:00:00", "11:00:00"),
                new Lesson(9, 3, "14:00:00", "15:00:00"),
                new Lesson(10, 4, "08:00:00", "09:00:00"),
                new Lesson(11, 4, "10:00:00", "11:00:00"),
                new Lesson(12, 4, "14:00:00", "15:00:00"),
                new Lesson(13, 5, "08:00:00", "09:00:00"),
                new Lesson(14, 5, "10:00:00", "11:00:00"),
                new Lesson(15, 5, "14:00:00", "15:00:00"),
            };
        }
    }
}
