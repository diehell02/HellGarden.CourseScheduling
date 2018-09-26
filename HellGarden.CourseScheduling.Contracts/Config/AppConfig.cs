using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.Domain.Config
{
    public class AppConfig
    {
        public List<CourseType> CourseTypes
        {
            get;
            set;
        }

        public class CourseType
        {
            public string Name
            {
                get;
                set;
            }

            public CourseTypeData Data
            {
                get;
                set;
            }

            public class CourseTypeData
            {
                public int WeekDay
                {
                    get;
                    set;
                }

                public int Min
                {
                    get;
                    set;
                }

                public int Max
                {
                    get;
                    set;
                }
            }
        }
    }
}
