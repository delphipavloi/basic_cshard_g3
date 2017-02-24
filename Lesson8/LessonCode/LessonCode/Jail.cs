using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCode
{
    public class Jail<T> : IJail<T> where T : IAlive
    {
        T[] creatures = new T[10];
        int current = 0;

        public void AddCreature(T alive)
        {
            creatures[current] = alive;
            alive.Speak();
            alive.Walk();
           
            current++;
        }

        public T[] GetAllCreatures()
        {
            return creatures;
        }
    }

}
