using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCode
{
    public interface IJail<T> where T : IAlive
    {
        void AddCreature(T alive);
        T[] GetAllCreatures();
    }
}
