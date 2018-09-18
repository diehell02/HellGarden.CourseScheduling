using HellGarden.CourseScheduling.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.DataAccess.Repository.SQLite.Context
{
    public class SQLiteContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(string.Format("Data Source={0}", "CourseScheduling.db"));
        }

        public DbSet<Class> Classes
        {
            get;
            set;
        }

        public DbSet<Lesson> Lessons
        {
            get;
            set;
        }

        public DbSet<Schedule> Schedules
        {
            get;
            set;
        }
    }
}
