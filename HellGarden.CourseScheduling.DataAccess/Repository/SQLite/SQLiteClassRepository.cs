using HellGarden.CourseScheduling.DataAccess.Repository.SQLite.Context;
using HellGarden.CourseScheduling.Domain.Entity;
using HellGarden.CourseScheduling.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.DataAccess.Repository.SQLite
{
    public class SQLiteClassRepository : ClassRepository
    {
        SQLiteContext context = null;

        public SQLiteClassRepository(SQLiteContext context)
        {
            this.context = context;
        }

        public override IEnumerable<Class> Get()
        {
            return context.Classes;
        }

        public override void Add(Class @class)
        {
            context.Classes.Add(@class);

            context.SaveChanges();
        }

        public override void Remove(Class @class)
        {
            context.Remove(@class);

            context.SaveChanges();
        }
    }
}
