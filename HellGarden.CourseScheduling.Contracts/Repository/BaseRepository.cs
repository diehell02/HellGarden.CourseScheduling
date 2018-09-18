using System;
using System.Collections.Generic;
using System.Text;

namespace HellGarden.CourseScheduling.Domain.Repository
{
    public abstract class BaseRepository<T>
    {
        public abstract void Add(T item);

        public abstract void Remove(T item);

        public abstract IEnumerable<T> Get();
    }
}
