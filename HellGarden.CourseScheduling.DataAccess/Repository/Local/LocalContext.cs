using HellGarden.CourseScheduling.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.DataAccess.Repository.Local
{
    public class LocalContext
    {
        public LocalContext()
        {
            Classes = new List<Class>();
            Lessons = new List<Lesson>();
            Schedules = new List<Schedule>();
            Teachers = new List<Teacher>();
        }

        public List<Class> Classes
        {
            get;
            private set;
        }

        public List<Lesson> Lessons
        {
            get;
            private set;
        }

        public List<Schedule> Schedules
        {
            get;
            private set;
        }

        public List<Teacher> Teachers
        {
            get;
            private set;
        }
    }
}
