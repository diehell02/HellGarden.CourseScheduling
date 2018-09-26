using HellGarden.CourseScheduling.Domain.Entity;
using HellGarden.CourseScheduling.Domain.Enum;
using HellGarden.CourseScheduling.Domain.Repository;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellGarden.CourseScheduling.ConsoleApp
{
    class FileUtil
    {
        public static void Save(Schedule[] schedules, ClassRepository classRepository, LessonRepository lessonRepository)
        {
            string path = string.Format(@"{0}\outport.xlsx", AppDomain.CurrentDomain.BaseDirectory);

            IWorkbook workbook = null;

            var fs = File.OpenWrite(path);

            if (path.IndexOf(".xlsx") > 0) // 2007版本 
            {
                workbook = new XSSFWorkbook();
            }
            else if (path.IndexOf(".xls") > 0) // 2003版本
            {
                workbook = new HSSFWorkbook();
            }

            var lessons = lessonRepository.Get();
            var classes = classRepository.Get();

            if (schedules.Length > 0)
            {
                var classSchedules = new Dictionary<Class, List<Schedule>>();

                foreach (var schedule in schedules)
                {
                    var @class = classes.Where(_class => _class.ID == schedule.ClassID).First();

                    if(!classSchedules.ContainsKey(@class))
                    {
                        var _schedules = new List<Schedule>() { schedule };
                        classSchedules.Add(@class, _schedules);
                    }
                    else
                    {
                        classSchedules[@class].Add(schedule);
                    }
                }

                var classSchedulesList = classSchedules.ToList();

                classSchedulesList.Sort((x, y) =>
                {
                    return x.Key.ID.CompareTo(y.Key.ID);
                });

                foreach (var keyValue in classSchedulesList)
                {
                    var _class = keyValue.Key;
                    var _schedules = keyValue.Value;

                    ISheet sheet = workbook.CreateSheet(_class.Name);

                    int rowIndex = 0;
                    int colIndex = 0;
                    IRow row = null;

                    row = sheet.CreateRow(rowIndex++);

                    row.CreateCell(colIndex++).SetCellValue("一");
                    row.CreateCell(colIndex++).SetCellValue("二");
                    row.CreateCell(colIndex++).SetCellValue("三");
                    row.CreateCell(colIndex++).SetCellValue("四");
                    row.CreateCell(colIndex++).SetCellValue("五");

                    rowIndex = 0;
                    colIndex = 0;
                    foreach (var schedule in _schedules)
                    {
                        var lesson = lessons.Where(_lesson => _lesson.ID == schedule.LessonID).First();

                        rowIndex = lesson.No;
                        colIndex = lesson.WeekDay - 1;

                        var course = _class.Courses.Where(_course => _course.CourseType == schedule.CourseType).First();

                        row = sheet.GetRow(rowIndex);

                        if(row == null)
                        {
                            row = sheet.CreateRow(rowIndex);
                        }
                        
                        row.CreateCell(colIndex).SetCellValue(course.Name);
                    }
                }
            }

            workbook.Write(fs);

            fs.Close();
        }

        private static List<Lesson> GetLessons(ISheet sheet)
        {
            var lessons = new List<Lesson>();

            var row = sheet.GetRow(1);

            int days = (int)row.GetCell(0).NumericCellValue;
            int period = (int)row.GetCell(1).NumericCellValue;

            int id = 1;
            for(int i = 1; i <= days; i++)
            {
                for(int j = 1; j <= period; j++)
                {
                    lessons.Add(new Lesson(id++, i, j, ""));
                }                
            }

            return lessons;
        }

        private static List<CourseType> GetCourses(ISheet sheet)
        {
            var courses = new List<CourseType>();

            for (int i = 1; i <= sheet.LastRowNum; i++)
            {
                var row = sheet.GetRow(i);
                var name = row.GetCell(0).StringCellValue;
                var period = (int)row.GetCell(1).NumericCellValue;
                var weekDay = (int)row.GetCell(2).NumericCellValue;
                var min = (int)row.GetCell(3).NumericCellValue;
                var max = (int)row.GetCell(4).NumericCellValue;
                var isCommon = (int)row.GetCell(5).NumericCellValue;

                courses.Add(new CourseType(name, period, weekDay, min, max, isCommon));
            }

            return courses;
        }

        private static List<Class> GetClasses(ISheet sheet, List<CourseType> courses, List<Teacher> teachers)
        {
            var classes = new List<Class>();
            var teacherID = 1;
            var classesCourses = new Dictionary<int, List<Course>>();

            for (int i = 1; i <= sheet.LastRowNum; i++)
            {
                var row = sheet.GetRow(i);
                var courseName = row.GetCell(0).StringCellValue;
                CourseType courseType = null;

                var result = courses.Where(course => course.Name == courseName);
                if(result.Count() > 0)
                {
                    courseType = result.First();
                }

                if (courseType != null)
                {
                    for (int j = 1; j < row.LastCellNum; j++)
                    {
                        if(!classesCourses.ContainsKey(j))
                        {
                            classesCourses.Add(j, new List<Course>());
                        }

                        var classCourses = classesCourses[j];
                        var teacherName = row.GetCell(j).StringCellValue;

                        if(!string.IsNullOrEmpty(teacherName))
                        {
                            Teacher teacher = null;
                            var _teacherResult = teachers.Where(_teacher => _teacher.Name == teacherName);
                            if (_teacherResult.Count() == 0)
                            {
                                teacher = new Teacher(teacherID++, teacherName);
                                teachers.Add(teacher);
                            }
                            else
                            {
                                teacher = _teacherResult.First();
                            }

                            if (classCourses.Where(classCourse => classCourse.CourseType == courseType).Count() == 0)
                            {
                                classCourses.Add(new Course(teacher.ID, courseType));
                            }
                        }
                    }
                }
            }

            int classID = 1;
            foreach(var classCourses in classesCourses)
            {
                courses.ForEach(courseType =>
                {
                    if(courseType.IsCommon && classCourses.Value.Where(_course => _course.CourseType != courseType).Count() > 0)
                    {
                        classCourses.Value.Add(new Course(0, courseType));
                    }
                });

                classes.Add(new Class(classID++, string.Format($"Class{classCourses.Key}"), classCourses.Value.ToArray()));
            }

            return classes;
        }

        public static void Import(string path, ClassRepository classRepository, LessonRepository lessonRepository, ScheduleRepository scheduleRepository, TeacherRepository teacherRepository)
        {
            List<Lesson> lessons = null;
            List<Teacher> teachers = null;
            List<Class> classes = null;
            List<Schedule> schedules = null;

            IWorkbook workbook = null;

            var fs = File.OpenRead(path);

            if (path.IndexOf(".xlsx") > 0) // 2007版本 
            {
                workbook = new XSSFWorkbook(fs);
            }
            else if (path.IndexOf(".xls") > 0) // 2003版本
            {
                workbook = new HSSFWorkbook(fs);
            }

            var courses = GetCourses(workbook.GetSheet("科目"));

            // TODO: 导入Lesson
            lessons = GetLessons(workbook.GetSheet("课程表"));

            // TODO: 导入Class
            teachers = new List<Teacher>();
            classes = GetClasses(workbook.GetSheet("班级"), courses, teachers);

            // TODO: 导入Schedule
            schedules = new List<Schedule>();

            lessons.ForEach(lesson =>
            {
                lessonRepository.Add(lesson);
            });

            teachers.ForEach(teacher =>
            {
                teacherRepository.Add(teacher);
            });

            classes.ForEach(@class =>
            {
                classRepository.Add(@class);
            });

            schedules.ForEach(schedule =>
            {
                scheduleRepository.Add(schedule);
            });
        }
    }
}
