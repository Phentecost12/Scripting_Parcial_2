using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class Equipment
    {
        string name;

        int val;
        public int Val { get => val; }

        protected int dur;
        public int Dur { get => dur; set => dur = value; }

        Type type;
        public Type Type { get => type;}

        public Equipment(string name, int val, int dur, Type type)
        {

            if (val < 0)
            {
                val *= -1;
            }
            else if (val == 0)
            {
                val = 10;
            }

            if (dur < 0)
            {
                dur *= -1;
            }
            else if (dur == 0)
            {
                dur = 2;
            }

            this.name = name;
            this.val = val;
            this.dur = dur;
            this.type = type;
        }

        

    }
}
