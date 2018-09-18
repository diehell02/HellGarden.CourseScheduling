using HellGarden.CourseScheduling.DataAccess.Repository.SQLite.Context;
using HellGarden.CourseScheduling.Domain.Entity;
using HellGarden.CourseScheduling.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.DataAccess.Repository.SQLite
{
    class SQLiteLessonRepository : LessonRepository
    {
        SQLiteContext context = null;

        public SQLiteLessonRepository(SQLiteContext context)
        {
            this.context = context;
        }

        public override IEnumerable<Lesson> Get()
        {
            return context.Lessons;
        }

        public override void Add(Lesson lesson)
        {
            context.Lessons.Add(lesson);

            context.SaveChanges();
        }

        public override void Remove(Lesson lesson)
        {
            context.Lessons.Remove(lesson);

            context.SaveChanges();
        }
    }
}
