using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb_1
{
    class Test
    {
        public string Discipline
        {
            get;
            set;
        }
        public bool Zach
        {
            get;
            set;
        }

        public Test()
        {
            Discipline = "Default";
            Zach = false;
        }
        public Test(string discipline, bool zach)
        {
            Discipline = discipline;
            Zach = zach;
        }
        public override string ToString()
        {
            string str;
            if (Zach)
            {
                str = "Зачтено";
            }
            else
            {
                str = "Не зачтено";
            }
            return Discipline + " - " + str;
        }
    }
}
