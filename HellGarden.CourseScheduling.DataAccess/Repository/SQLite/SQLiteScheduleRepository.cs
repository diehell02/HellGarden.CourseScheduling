using HellGarden.CourseScheduling.DataAccess.Repository.SQLite.Context;
using HellGarden.CourseScheduling.Domain.Entity;
using HellGarden.CourseScheduling.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.DataAccess.Repository.SQLite
{
    class SQLiteScheduleRepository : ScheduleRepository
    {
        SQLiteContext context = null;

        public SQLiteScheduleRepository(SQLiteContext context)
        {
            this.context = context;
        }

        public override IEnumerable<Schedule> Get()
        {
            return context.Schedules;
        }

        public override void Add(Schedule schedule)
        {
            context.Schedules.Add(schedule);

            context.SaveChanges();
        }

        public override void Remove(Schedule schedule)
        {
            context.Schedules.Remove(schedule);

            context.SaveChanges();
        }
    }
}
