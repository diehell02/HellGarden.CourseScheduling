using HellGarden.CourseScheduling.Domain.Entity;
using HellGarden.CourseScheduling.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.DataAccess.Repository.Local
{
    public class LocalClassRepository : ClassRepository
    {
        LocalContext context = null;

        public LocalClassRepository(LocalContext context)
        {
            this.context = context;
        }

        public override void Add(Class @class)
        {
            context.Classes.Add(@class);
        }

        public override void Remove(Class @class)
        {
            context.Classes.Remove(@class);
        }

        public override IEnumerable<Class> Get()
        {
            return context.Classes;
        }
    }
}
