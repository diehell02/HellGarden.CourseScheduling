using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.Domain.Entity
{
    public class Class
    {
        public Class(int id, string name, Course[] courses)
        {
            ID = id;
            Name = name;
            Courses = courses;
        }

        public int ID
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            private set;
        }

        public Course[] Courses { get; private set; }

        public Course GetAvailableCourse()
        {
            List<Course> courses = new List<Course>();

            foreach(var course in Courses)
            {
                if(course.RemainLessonPeriod > 0)
                {
                    courses.Add(course);
                }
            }

            if(courses.Count > 0)
            {
                int index = new Random().Next(courses.Count);

                return courses[index];
            }
            else
            {
                return null;
            }
        }

        public void ResetCourse()
        {
            foreach (var course in Courses)
            {
                course.ResetLessonPeriod();
            }
        }

        //public void Swap()
        //{
        //    int length = Courses.Length;
        //    Random random = new Random();
        //    int index1 = random.Next(length);
        //    int index2 = random.Next(length);

        //    var temp = teachers[index1];
        //    teachers[index1] = teachers[index2];
        //    teachers[index2] = temp;
        //}

        //public void Reset()
        //{
        //}
    }
}
