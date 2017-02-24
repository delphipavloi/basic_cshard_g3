using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCode
{
    public class Human : Creature
    {

        public Human(string name) : base(name)
        {
        }

        public override void Feed()
        {
            throw new NotImplementedException();
        }


        public override void Speak()
        {
            Console.WriteLine("I'm only human after all.");
        }

        public override void Walk()
        {
            Console.WriteLine("Human walks");
        }
    }
}
