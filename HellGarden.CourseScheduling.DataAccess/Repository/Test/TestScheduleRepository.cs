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
        public override void Add(Schedule @class)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Schedule> Get()
        {
            throw new NotImplementedException();
        }

        public override void Remove(Schedule @class)
        {
            throw new NotImplementedException();
        }
    }
}
