using HellGarden.CourseScheduling.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HellGarden.CourseScheduling.DataAccess.Repository.Local;
using HellGarden.CourseScheduling.Domain.Repository;
using HellGarden.CourseScheduling.Domain.Entity;
using System.IO;

namespace HellGarden.CourseScheduling.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new LocalContext();
            var classRepository = new LocalClassRepository(context);
            var lessonRepository = new LocalLessonRepository(context);
            var scheduleRepository = new LocalScheduleRepository(context);
            var teacherRepository = new LocalTeacherRepository(context);

            // 导入
            string importPath = string.Empty;

            while (string.IsNullOrEmpty(importPath))
            {
                Console.WriteLine("请输入导入文件路径：");
                importPath = Console.ReadLine();

                if(!File.Exists(importPath))
                {
                    importPath = string.Empty;
                    Console.WriteLine("文件路径有误，请重新输入");
                }
            }

            FileUtil.Import(importPath, classRepository, lessonRepository, scheduleRepository, teacherRepository);

            var scheduling = new Scheduling();

            var result = scheduling.Do(classRepository, scheduleRepository, lessonRepository);

            // 导出
            string outportPath = string.Format(@"{0}导出\outport.xlsx", AppDomain.CurrentDomain.BaseDirectory);

            FileUtil.Save(outportPath, result, classRepository, lessonRepository);

            Console.WriteLine("导出完毕");
            Console.WriteLine("导出地址:{0}", outportPath);

            Console.ReadLine();
        }
    }
}
