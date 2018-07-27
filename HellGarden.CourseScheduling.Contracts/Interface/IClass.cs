using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.Domain.Interface
{
    public interface IClass
    {
        int ID
        {
            get;
        }

        /// <summary>
        /// 班级名称
        /// </summary>
        string Name
        {
            get;
        }

        /// <summary>
        /// 科目
        /// </summary>
        ICourse[] Courses
        {
            get;
        }

        /// <summary>
        /// 教师
        /// </summary>
        ITeacher[] Teacher
        {
            get;
        }

        /// <summary>
        /// 课程安排
        /// </summary>
        LinkedList<ILesson> Lessons
        {
            get;
        }

        /// <summary>
        /// 获取可用的科目
        /// </summary>
        /// <returns></returns>
        ICourse GetAvailableCourse();

        /// <summary>
        /// 对调顺序
        /// </summary>
        void Swap();

        /// <summary>
        /// 重置
        /// </summary>
        void Reset();
    }
}
