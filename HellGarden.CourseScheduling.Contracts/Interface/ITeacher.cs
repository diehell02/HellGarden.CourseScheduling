using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.Domain.Interface
{
    /// <summary>
    /// 教师
    /// </summary>
    public interface ITeacher
    {
        int ID
        {
            get;
        }

        /// <summary>
        /// 名称
        /// </summary>
        string Name
        {
            get;
        }
    }
}
