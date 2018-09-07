﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HellGarden.CourseScheduling.Domain.Entity
{
    public class Class
    {
        Random random = new Random();

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

        public Course GetAvailableCourse(int lessonID)
        {
            List<Course> courses = new List<Course>();

            foreach (var course in Courses)
            {
                if (course.RemainLessonPeriod > 0)
                {
                    for (int i = 0; i < course.RemainLessonPeriod; i++)
                    {
                        courses.Insert(random.Next(courses.Count), course);
                    }
                }
            }

            return courses[random.Next(courses.Count)];
        }

        public List<KeyValuePair<Lesson, Course>> GetLessonCourses(List<Lesson> lessons)
        {
            List<KeyValuePair<Lesson, Course>> keyValuePairs = new List<KeyValuePair<Lesson, Course>>();
            List<Course> courses = new List<Course>();

            foreach (var course in Courses)
            {
                if (course.RemainLessonPeriod > 0)
                {
                    for (int i = 0; i < course.RemainLessonPeriod; i++)
                    {
                        courses.Insert(random.Next(courses.Count), course);
                    }
                }
            }

            courses.ForEach(course =>
            {
                var lesson = lessons[random.Next(lessons.Count)];
                lessons.Remove(lesson);

                var keyValuePair = new KeyValuePair<Lesson, Course>(lesson, course);

                keyValuePairs.Insert(random.Next(keyValuePairs.Count), keyValuePair);
            });

            lessons.ForEach(lesson =>
            {
                var keyValuePair = new KeyValuePair<Lesson, Course>(lesson, null);

                keyValuePairs.Insert(random.Next(keyValuePairs.Count), keyValuePair);
            });

            return keyValuePairs;
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
