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
        public Schedule[] Do(ClassRepository classRepository, ScheduleRepository scheduleRepository, LessonRepository lessonRepository)
        {
            Schedule[] result = null;

            var lessons = new List<Lesson>(lessonRepository.Get());
            var classes = classRepository.Get();
            var classesCount = classes.Count();
            List<Schedule> schedules = new List<Schedule>();                   
            List<Class> isScheduleClasses = new List<Class>();

            int days = 0;
            int period = 0;

            foreach(var lesson in lessons)
            {
                days = Math.Max(lesson.WeekDay, days);
                period = Math.Max(lesson.No, period);
            }

            int count = 0;

            while (true)
            {
                count++;
                //int index = new Random().Next(classesCount);
                //classes.ElementAt(index).Swap();

                //schedules.Clear();

                bool flag0 = false;
                foreach (var @class in classes)
                {
                    if(isScheduleClasses.Contains(@class))
                    {
                        continue;
                    }

                    @class.ResetCourse();

                    bool flag1 = false;
                    List<Schedule> _schedules = new List<Schedule>();

                    //foreach (var lesson in lessons)
                    //{
                    //    var lessonID = lesson.ID;

                    //    var course = @class.GetAvailableCourse(lessonID);

                    //    var teacherID = course.TeacherID;

                    //    if (!scheduleRepository.IsTeacherAvaliable(teacherID, lessonID))
                    //    {
                    //        flag1 = true;
                    //        break;
                    //    }
                    //    else
                    //    {
                    //        if(teacherID > 0)
                    //        {
                    //            var temp = new List<Schedule>();
                    //            temp.AddRange(schedules);
                    //            temp.AddRange(_schedules);

                    //            var _schedulesResult = temp.Where(schedule => schedule.TeacherID > 0 && schedule.TeacherID == teacherID && schedule.LessonID == lessonID);
                    //            if (_schedulesResult.Count() > 0)
                    //            {
                    //                flag1 = true;
                    //                break;
                    //            }
                    //        }

                    //        flag1 = false;
                    //        course.ScheduleLesson();
                    //        _schedules.Add(new Schedule(ScheduleType.Schedule, @class.ID, lessonID, teacherID, course.CourseType));
                    //        continue;
                    //    }
                    //}

                    var keyValuePairs = @class.GetLessonCourses(lessons, days, period);

                    foreach(var keyValuePair in keyValuePairs)
                    {
                        var lesson = keyValuePair.Key;
                        var course = keyValuePair.Value;

                        var teacherID = course.TeacherID;
                        var lessonID = lesson.ID;

                        if (!scheduleRepository.IsTeacherAvaliable(teacherID, lessonID))
                        {
                            flag1 = true;
                            break;
                        }
                        else
                        {
                            if (teacherID > 0)
                            {
                                var temp = new List<Schedule>();
                                temp.AddRange(schedules);
                                temp.AddRange(_schedules);

                                var _schedulesResult = temp.Where(schedule => schedule.TeacherID > 0 && schedule.TeacherID == teacherID && schedule.LessonID == lessonID);
                                if (_schedulesResult.Count() > 0)
                                {
                                    flag1 = true;
                                    break;
                                }
                            }

                            flag1 = false;
                            course.ScheduleLesson();
                            _schedules.Add(new Schedule(ScheduleType.Schedule, @class.ID, lessonID, teacherID, course.CourseType));
                            continue;
                        }
                    }

                    if (flag1)
                    {
                        continue;
                    }
                    else
                    {
                        isScheduleClasses.Add(@class);
                        schedules.AddRange(_schedules);
                    }
                }

                if (isScheduleClasses.Count == classesCount)
                {
                    // 筛选结果
                    foreach(var lesson in lessons)
                    {
                        var id = lesson.ID;

                        var _schedules = schedules.Where(schedule => schedule.LessonID == id && schedule.TeacherID > 0);
                        var distinct = _schedules.Distinct(m => m.TeacherID);

                        if (distinct.Count() < _schedules.Count())
                        {
                            isScheduleClasses.Clear();
                            schedules.Clear();
                        }
                    }


                    if(schedules.Count > 0)
                    {
                        // 保存结果
                        result = new Schedule[schedules.Count];
                        schedules.CopyTo(result);

                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return result;
        }
    }
}
