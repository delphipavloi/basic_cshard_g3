using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCode
{
    public abstract class Creature : IAlive
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public Creature(string name)
        {
            Name = name;
        }

        public abstract void Feed();

        public abstract void Walk();
        public abstract void Speak();
    }
}