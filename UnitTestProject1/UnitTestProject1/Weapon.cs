using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    internal class Weapon:Equipment
    {

        public Weapon(string name, int val, int dur, Type type) : base(name, val, dur, type) { }

        public void ReduceDurability()
        {
            base.dur--;
        }

    }
}
