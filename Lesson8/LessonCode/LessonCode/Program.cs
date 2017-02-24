using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Tony Stark");
            Cat cat = new Cat("Cat from Shrek");

            ISpeaker catSpeak = cat;
            ISpeaker humSpeak = human;
            ISpeaker[] speakers = new ISpeaker[3];

            speakers[0] = new Human("Black Widow");
            speakers[1] = new Cat("Pink Panter");
            speakers[2] = new Cat("Black Panter");
            IAlive aliveHum = new Human("Capitan America");
            ISpeaker s = aliveHum;
            
            Talk(speakers);
            Feed(human);
            Feed("Hahaha");
            Jail<Human> jails = new Jail<Human>();
            jails.AddCreature(human);
            
                       
            Console.ReadLine();
            
        }


        static void Talk(ISpeaker[] speakers)
        {
            for (int i = 0; i < speakers.Length; i++)
            {
                speakers[i].Speak();
            }
        }

        static void Feed(object creature)
        {
            //Human human = (Human)creature;
            Human human = creature as Human;
            if (creature is Human)
            {
                human = (Human)creature;                
            }
            if (creature is Cat)
            {
                Cat cat = (Cat)creature;
            }
        }
    }
}
