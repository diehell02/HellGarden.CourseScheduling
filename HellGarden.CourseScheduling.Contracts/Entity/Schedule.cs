using HellGarden.CourseScheduling.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.Domain.Entity
{
    public class Schedule
    {
        public Schedule(ScheduleType scheduleType, int classID, int lessonID, int teacherID, CourseType courseType)
        {
            ScheduleType = scheduleType;
            ClassID = classID;
            LessonID = lessonID;
            TeacherID = teacherID;
            CourseType = courseType;
        }

        public int ClassID
        {
            get;
            private set;
        }

        public int LessonID
        {
            get;
            private set;
        }

        public int TeacherID
        {
            get;
            private set;
        }

        public ScheduleType ScheduleType
        {
            get;
            private set;
        }

        public CourseType CourseType
        {
            get;
            private set;
        }
    }
}
