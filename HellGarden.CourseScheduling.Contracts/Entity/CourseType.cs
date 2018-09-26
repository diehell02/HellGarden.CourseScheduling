using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.Domain.Entity
{
    public class CourseType
    {
        private CourseTypeEnum type;

        public CourseType(string name, int period, int weekDay, int min, int max, int common)
        {
            Name = name;
            Period = period;
            WeekDay = weekDay;
            Min = min;
            Max = max;
            IsCommon = common == 0 ? false : true;

            if (Min == 0 && Max == 0)
            {
                type = CourseTypeEnum.Normal;
            }
            else if(Min == Max)
            {
                type = CourseTypeEnum.Fixed;
            }
            else
            {
                type = CourseTypeEnum.Range;
            }
        }

        public string Name
        {
            get;
            private set;
        }

        public int Period
        {
            get;
            private set;
        }

        public int WeekDay
        {
            get;
            private set;
        }

        public int Min
        {
            get;
            private set;
        }

        public int Max
        {
            get;
            private set;
        }

        public bool IsCommon
        {
            get;
            private set;
        }

        public bool IsFit(Lesson lesson)
        {
            bool result = false;

            switch (type)
            {
                case CourseTypeEnum.Fixed:
                    if (lesson.No == Min)
                    {
                        if(WeekDay == 0)
                        {
                            result = true;
                        }
                        else if(WeekDay == lesson.WeekDay)
                        {
                            result = true;
                        }
                    }
                    break;
                case CourseTypeEnum.Range:
                    if (lesson.No >= Min && lesson.No <= Max)
                    {
                        if (WeekDay == 0)
                        {
                            result = true;
                        }
                        else if (WeekDay == lesson.WeekDay)
                        {
                            result = true;
                        }
                    }
                    break;
                default:
                    result = true;
                    break;
            }

            return result;
        }

        enum CourseTypeEnum
        {
            Fixed,
            Range,
            Normal,
        }
    }
}
