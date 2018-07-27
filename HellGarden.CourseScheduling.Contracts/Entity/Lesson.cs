using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.Domain.Entity
{
    public class Lesson
    {
        public Lesson(int id, int weekDay, string startTime, string endTime)
        {
            ID = id;
            WeekDay = weekDay;
            StartTime = startTime;
            EndTime = endTime;
        }

        public int ID
        {
            get;
            private set;
        }

        public int WeekDay
        {
            get;
            private set;
        }

        public string StartTime
        {
            get;
            private set;
        }

        public string EndTime
        {
            get;
            private set;
        }
    }
}
