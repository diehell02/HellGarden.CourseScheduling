using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.Domain.Entity
{
    public class Teacher
    {
        public int ID
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
    }
}
