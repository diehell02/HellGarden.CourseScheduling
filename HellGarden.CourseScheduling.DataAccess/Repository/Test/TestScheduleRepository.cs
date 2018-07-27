using HellGarden.CourseScheduling.Domain.Entity;
using HellGarden.CourseScheduling.Domain.Enum;
using HellGarden.CourseScheduling.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.DataAccess.Repository.Test
{
    public class TestScheduleRepository : ScheduleRepository
    {
        public override IEnumerable<Schedule> GetSchedules()
        {
            return new List<Schedule>();
        }

        protected override IEnumerable<Schedule> GetSchedules(int teacherID)
        {
            return new List<Schedule>();
        }

        public override bool Add(int classID, int teacherID, int lessonID, ScheduleType scheduleType)
        {
            return true;
        }
    }
}
