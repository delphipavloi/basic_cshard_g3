using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCode
{
    public class HumanJail : IJail<Human>
    {
        public void AddCreature(Human alive)
        {
            throw new NotImplementedException();
        }

        public Human[] GetAllCreatures()
        {
            throw new NotImplementedException();
        }
    }
}
