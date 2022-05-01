using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Vetters
{
    class Owl : TinyBeast
    {
        public Owl() : base()
        {
            this.Strength = 3;
            this.Dexterity = 13;
            this.Constitution = 8;
            this.Intelligence = 2;
            this.Wisdom = 12;
            this.Charisma = 7;

            //HP 1d4s-1
            this.HP = Dice.Roll(1, 4, -1);

            this.ArmorClass = 11; //natural armor
            this.Resistances += "Stealth ";
            this.Darkvision = true;
        }
        /* methods */

        /* Talons: 
           Melee Weapon Attack: +3 to hit, reach 5 ft., one creature. 
           Hit: (1d1) slashing damage.
        */
        public string Talon(Creature def)
        {
            int toHit = Dice.Roll(20, 3);
            if (toHit > def.ArmorClass || toHit == 20)
            {
                int damage = Dice.Roll(1, 1);
                def.HP -= damage;
                return "Owl sinks his talons into " + def.GetType().Name +
                        " for " + damage + " slashing damage!";
            }
            else
            {
                return "Owl fails to reach target " + def.GetType().Name + "!";
            }
        }
        public override string ToString()
        {
            return base.ToString()
                + "\nAttacks:\n  Talon";
        }

        public override string Attack(Creature c)
        {
            return Talon(c);
        }
    }
}
