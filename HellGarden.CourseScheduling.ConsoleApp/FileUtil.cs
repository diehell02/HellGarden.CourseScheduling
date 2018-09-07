using HellGarden.CourseScheduling.Domain.Entity;
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

            var lessons = lessonRepository.GetLessons();
            var classes = classRepository.GetClasses();

            if (schedules.Length > 0)
            {
                IDictionary<Class, List<Schedule>> classSchedules = new Dictionary<Class, List<Schedule>>();

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

                foreach(var keyValue in classSchedules)
                {
                    var _class = keyValue.Key;
                    var _schedules = keyValue.Value;

                    ISheet sheet = workbook.CreateSheet(_class.Name);

                    int rowIndex = 0;
                    int colIndex = 0;
                    IRow row = null;
                    ICell cell = null;

                    row = sheet.CreateRow(rowIndex++);

                    row.CreateCell(colIndex++).SetCellValue("周一");
                    row.CreateCell(colIndex++).SetCellValue("周二");
                    row.CreateCell(colIndex++).SetCellValue("周三");
                    row.CreateCell(colIndex++).SetCellValue("周四");
                    row.CreateCell(colIndex++).SetCellValue("周五");

                    rowIndex = 0;
                    colIndex = 0;
                    foreach (var schedule in _schedules)
                    {
                        var lesson = lessons.Where(_lesson => _lesson.ID == schedule.LessonID).First();

                        rowIndex = lesson.ID % 10;
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
    }
}
