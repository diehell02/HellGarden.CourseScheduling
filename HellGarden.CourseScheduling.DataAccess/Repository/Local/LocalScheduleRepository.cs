using HellGarden.CourseScheduling.Domain.Entity;
using HellGarden.CourseScheduling.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.DataAccess.Repository.Local
{
    public class LocalScheduleRepository : ScheduleRepository
    {
        LocalContext context = null;

        public LocalScheduleRepository(LocalContext context)
        {
            this.context = context;
        }

        public override void Add(Schedule schedule)
        {
            context.Schedules.Add(schedule);
        }

        public override void Remove(Schedule schedule)
        {
            context.Schedules.Remove(schedule);
        }

        public override IEnumerable<Schedule> Get()
        {
            return context.Schedules;
        }
    }
}
