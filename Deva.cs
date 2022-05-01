using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Vetters
{
    class Deva : MediumCelestial
    {
        public Deva() : base()
        {
            this.Strength = 18;
            this.Dexterity = 18;
            this.Constitution = 18;
            this.Intelligence = 17;
            this.Wisdom = 20;
            this.Charisma = 20;

            //HP 16d8s+64
            this.HP = Dice.Roll(16, 8, 64);

            this.ArmorClass = 17; //natural armor
            this.Resistances += "Radiant ";
            this.Darkvision = true;
        }

        /* methods */

        /* Mace: 
           Melee Weapon Attack: +8 to hit, reach 5 ft., one creature. 
           Hit: (1d6 + 4) bludgeoning damage.
        */
        public string Mace(Creature def)
        {
            int toHit = Dice.Roll(20, 8);
            if (toHit > def.ArmorClass || toHit == 20)
            {
                int damage = Dice.Roll(1, 6, 4) + Dice.Roll(4, 8);
                def.HP -= damage;
                return "Deva is successful " + def.GetType().Name +
                        " for " + damage + " bludgeoning damage!";
            }
            else
            {
                return "Deva fails to reach target " + def.GetType().Name + "!";
            }
        }

        public override string ToString()
        {
            return base.ToString()
                + "\nAttacks:\n  Mace";
        }

        public override string Attack(Creature c)
        {
            return Mace(c);
        }
    }
}
