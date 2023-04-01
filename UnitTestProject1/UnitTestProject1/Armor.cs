using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace UnitTestProject1
{
    internal class Armor : Equipment
    {
        public Armor(string name , int val, int dur, Type type) : base(name, val, dur, type) { }

        public void ReduceDurability(int damage)
        {
            if (damage == 0)
            {
                base.dur--;
                return;
            }

            decimal c = damage / 2;
            int blockDamage = (int)Math.Floor(c);
            if (base.dur - blockDamage <0 )
            {
                base.dur = 0;
            }
            else
            {
                base.dur -= blockDamage;
            }
            
        }
    }
}
