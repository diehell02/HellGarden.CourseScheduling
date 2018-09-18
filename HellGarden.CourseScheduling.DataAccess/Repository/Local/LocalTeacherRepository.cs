using HellGarden.CourseScheduling.Domain.Entity;
using HellGarden.CourseScheduling.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.DataAccess.Repository.Local
{
    public class LocalTeacherRepository: TeacherRepository
    {
        LocalContext context = null;

        public LocalTeacherRepository(LocalContext context)
        {
            this.context = context;
        }

        public override void Add(Teacher teacher)
        {
            context.Teachers.Add(teacher);
        }

        public override void Remove(Teacher teacher)
        {
            context.Teachers.Remove(teacher);
        }

        public override IEnumerable<Teacher> Get()
        {
            return context.Teachers;
        }
    }
}
