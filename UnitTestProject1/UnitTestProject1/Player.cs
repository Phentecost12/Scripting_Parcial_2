using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public enum Type
    {
        Human,Beast,Hybrid,ANY
    }

    public class Player
    {
        string name;

        int hp;
        public int Hp { get => hp; }

        static int baseAtk;
        public int BaseAtk { get => baseAtk; set => baseAtk = value; }
        static int baseDef = 5;
        Type type;
        Weapon equipedWeapon;
        internal Weapon EquipedWeapon { get => equipedWeapon;}

        Armor equipedArmor;
        internal Armor EquipedArmor { get => equipedArmor;}
        

        public Player(string name, int hp,Type type) 
        {
            if (hp < 0)
            {
                hp *= -1;
            }
            else if (hp == 0)
            {
                hp = 5;
            }


            this.name = name;
            this.hp = hp;
            this.type = type;
            baseAtk = 5; baseDef = 5;
            equipedArmor = null;
            equipedWeapon= null;

        }

        public bool EquipeEquipment(Equipment equipment)
        {
            if (equipment.Dur > 0)
            {
                if (equipment is Weapon)
                {
                    if (equipment.Type == type || equipment.Type == Type.ANY)
                    {
                        equipedWeapon = (Weapon)equipment;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (equipment is Armor)
                {
                    if (equipment.Type == type || equipment.Type == Type.ANY)
                    {
                        equipedArmor = (Armor)equipment;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return false;
        }

        public void TakeDamage(int Damage) 
        {
            if (equipedArmor != null)
            {
                equipedArmor.ReduceDurability(Damage);
                if (equipedArmor.Dur <= 0)
                {
                    equipedArmor = null;
                }
            }
            else
            {
                if (hp - Damage < 0)
                {
                    hp = 0;
                }
                else
                {
                    hp -= Damage;
                }
            }
        }

        public bool IsDead() 
        {
            return hp<=0?true:false;
        }

        public int DealDamage() 
        {
            int D; 
            if (equipedWeapon != null) 
            {
                D= equipedWeapon.Val;

                equipedWeapon.ReduceDurability();

                if (equipedWeapon.Dur == 0)
                {
                    equipedWeapon = null;
                }

            }
            else
            {
                D = baseAtk;
            }

            return D;
            
        }
    }
}
