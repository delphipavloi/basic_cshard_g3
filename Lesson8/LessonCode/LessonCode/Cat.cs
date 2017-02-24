using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCode
{
    public class Cat : Creature
    {
        public Cat(string name) : base(name)
        {
        }

        public int EeatenValeryanka { set; get; }

        public override void Feed()
        {
            throw new NotImplementedException();
        }

        public override void Speak()
        {
            Console.WriteLine("I'm only cat after all.");
        }

        public override void Walk()
        {
            throw new NotImplementedException();
        }
    }
}
