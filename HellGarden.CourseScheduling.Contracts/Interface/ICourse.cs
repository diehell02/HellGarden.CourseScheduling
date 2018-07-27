using HellGarden.CourseScheduling.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.Domain.Interface
{
    /// <summary>
    /// 科目
    /// </summary>
    public interface ICourse
    {
        int ID
        {
            get;
        }

        /// <summary>
        /// 教师ID
        /// </summary>
        int TeacherID
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

        /// <summary>
        /// 剩余课时
        /// </summary>
        int RemainLessonPeriod
        {
            get;
        }

        CourseType CourseType
        {
            get;
        }
    }
}
