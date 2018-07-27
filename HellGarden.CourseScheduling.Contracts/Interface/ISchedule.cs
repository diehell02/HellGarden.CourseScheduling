using HellGarden.CourseScheduling.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.Domain.Interface
{
    public interface ISchedule
    {
        int ClassID
        {
            get;
        }

        int LessonID
        {
            get;
        }

        int TeacherID
        {
            get;
        }

        ScheduleType ScheduleType
        {
            get;
        }
    }
}
