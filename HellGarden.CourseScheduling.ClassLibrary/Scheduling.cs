using System;
using System.Collections.Generic;
using System.Text;
using HellGarden.CourseScheduling.Domain.Entity;
using System.Linq;
using HellGarden.CourseScheduling.Domain.Repository;
using HellGarden.CourseScheduling.Domain.Enum;

namespace HellGarden.CourseScheduling.ClassLibrary
{
    public class Scheduling
    {
        public List<Schedule[]> Do(ClassRepository classRepository, ScheduleRepository scheduleRepository, LessonRepository lessonRepository)
        {
            List<Schedule[]> result = new List<Schedule[]>();

            var lessons = lessonRepository.GetLessons();

            var classes = classRepository.GetClasses();
            var classesCount = classes.Count();
            List<Schedule> schedules = new List<Schedule>();
            int count = 0;

            while(count++ < 100000)
            {
                //int index = new Random().Next(classesCount);
                //classes.ElementAt(index).Swap();

                schedules.Clear();

                bool flag0 = false;
                foreach (var @class in classes)
                {
                    @class.ResetCourse();

                    bool flag1 = false;

                    foreach (var lesson in lessons)
                    {
                        var lessonID = lesson.ID;

                        var course = @class.GetAvailableCourse();

                        if (course is null)
                        {
                            break;
                        }

                        var teacherID = course.TeacherID;

                        if (!scheduleRepository.IsTeacherAvaliable(teacherID, lessonID))
                        {
                            flag1 = true;
                            break;
                        }
                        else
                        {
                            var _schedules = schedules.Where(schedule => schedule.TeacherID == teacherID && schedule.LessonID == lessonID);
                            if (_schedules.Count() > 0)
                            {
                                flag1 = true;
                                break;
                            }

                            course.ScheduleLesson();
                            schedules.Add(new Schedule(ScheduleType.Schedule, @class.ID, lessonID, teacherID));
                        }
                    }

                    if (flag1)
                    {
                        flag0 = true;
                        break;
                    }
                }

                if (!flag0)
                {
                    // 保存结果
                    schedules.AddRange(scheduleRepository.GetSchedules());
                    var array = new Schedule[schedules.Count];
                    schedules.CopyTo(array);
                    result.Add(array);
                }
            }

            // 筛选结果

            return result;
        }
    }
}
