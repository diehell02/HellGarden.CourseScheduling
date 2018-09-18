using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.Domain.Entity
{
    public class Lesson
    {
        public Lesson(int id, int weekDay, int no, string remark)
        {
            ID = id;
            WeekDay = weekDay;
            No = no;
            Remark = remark;
        }

        public Lesson(int id, int weekDay, string remark)
        {
            ID = id;
            WeekDay = weekDay;
            No = ID;
            Remark = remark;
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

        public int No
        {
            get;
            private set;
        }

        public string Remark
        {
            get;
            private set;
        }
    }
}
