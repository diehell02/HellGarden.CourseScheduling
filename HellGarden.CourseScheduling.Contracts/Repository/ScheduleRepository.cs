using HellGarden.CourseScheduling.Domain.Entity;
using HellGarden.CourseScheduling.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.Domain.Repository
{
    public abstract class ScheduleRepository
    {
        public abstract IEnumerable<Schedule> GetSchedules();

        protected abstract IEnumerable<Schedule> GetSchedules(int teacherID);

        public abstract bool Add(int classID, int teacherID, int lessonID, ScheduleType scheduleType);

        public bool IsTeacherAvaliable(int teacherID, int lessonID)
        {
            var schedules = GetSchedules(teacherID);

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
