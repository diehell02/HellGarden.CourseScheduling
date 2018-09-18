using HellGarden.CourseScheduling.Domain.Entity;
using HellGarden.CourseScheduling.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.DataAccess.Repository.Local
{
    public class LocalLessonRepository : LessonRepository
    {
        LocalContext context = null;

        public LocalLessonRepository(LocalContext context)
        {
            this.context = context;
        }

        public override void Add(Lesson lesson)
        {
            context.Lessons.Add(lesson);
        }

        public override void Remove(Lesson lesson)
        {
            context.Lessons.Remove(lesson);
        }

        public override IEnumerable<Lesson> Get()
        {
            return context.Lessons;
        }
    }
}
