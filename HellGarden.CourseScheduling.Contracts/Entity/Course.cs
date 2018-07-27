using HellGarden.CourseScheduling.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.Domain.Entity
{
    public class Course
    {
        private int lessonPeriod;

        public Course(int teacherID, string name, int lessonPeriod, CourseType courseType)
        {
            this.lessonPeriod = lessonPeriod;

            TeacherID = teacherID;
            Name = name;
            RemainLessonPeriod = lessonPeriod;
            CourseType = courseType;
        }

        public int TeacherID
        {
            get;
            private set;
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get;
            private set;
        }

        /// <summary>
        /// 剩余课时
        /// </summary>
        public int RemainLessonPeriod
        {
            get;
            private set;
        }

        public CourseType CourseType
        {
            get;
            private set;
        }

        public void ScheduleLesson()
        {
            RemainLessonPeriod--;
        }

        public void ResetLessonPeriod()
        {
            RemainLessonPeriod = lessonPeriod;
        }
    }
}
