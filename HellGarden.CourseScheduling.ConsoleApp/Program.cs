using HellGarden.CourseScheduling.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
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
            string path = string.Empty;

            while (string.IsNullOrEmpty(path))
            {
                Console.WriteLine("请输入导入文件路径：");
                path = Console.ReadLine();

                if(!File.Exists(path))
                {
                    path = string.Empty;
                    Console.WriteLine("文件路径有误，请重新输入");
                }
            }

            FileUtil.Import(path, classRepository, lessonRepository, scheduleRepository, teacherRepository);

            var scheduling = new Scheduling();

            var result = scheduling.Do(classRepository, scheduleRepository, lessonRepository);

            FileUtil.Save(result, classRepository, lessonRepository);

            Console.WriteLine("导出完毕");

            Console.ReadLine();
        }
    }
}
