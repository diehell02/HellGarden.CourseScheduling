using HellGarden.CourseScheduling.Domain.Entity;
using HellGarden.CourseScheduling.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HellGarden.CourseScheduling.Domain.Repository
{
    public abstract class ScheduleRepository : BaseRepository<Schedule>
    {
        private IEnumerable<Schedule> Get(int teacherID)
        {
            var schedules = Get();

            return schedules.Where(schedule => { return schedule.TeacherID == teacherID; });
        }

        public bool IsTeacherAvaliable(int teacherID, int lessonID)
        {
            var schedules = Get(teacherID);

            foreach(var schedule in schedules)
            {
                if(schedule.LessonID == lessonID)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
