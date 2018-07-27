using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.Domain.Interface
{
    /// <summary>
    /// 课程
    /// </summary>
    public interface ILesson
    {
        int ID
        {
            get;
        }

        /// <summary>
        /// 周几
        /// </summary>
        int WeekDay
        {
            get;
        }

        /// <summary>
        /// 开始时间
        /// </summary>
        string StartTime
        {
            get;
        }

        /// <summary>
        /// 结束时间
        /// </summary>
        string EndTime
        {
            get;
        }
    }
}
