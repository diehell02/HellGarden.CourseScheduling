using HellGarden.CourseScheduling.ClassLibrary;
using HellGarden.CourseScheduling.DataAccess.Repository.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HellGarden.CourseScheduling.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var scheduling = new Scheduling();

            var result = scheduling.Do(new TestClassRepository(), new TestScheduleRepository(), new TestLessonRepository());

            //result.ForEach(schedules =>
            //{
            //    Console.WriteLine("——————————————分割线——————————————");
            //    Console.WriteLine(JsonConvert.SerializeObject(schedules, Formatting.Indented));
            //});

            FileUtil.Save(result, new TestClassRepository(), new TestLessonRepository());

            Console.ReadLine();
        }
    }
}
