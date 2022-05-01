using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Vetters
{
    class Couatl : MediumCelestial
    {
        public Couatl() : base()
        {
            this.Strength = 16;
            this.Dexterity = 20;
            this.Constitution = 17;
            this.Intelligence = 18;
            this.Wisdom = 20;
            this.Charisma = 18;

            //HP 13d8s+39
            this.HP = Dice.Roll(13, 8, 39);

            this.ArmorClass = 19; //natural armor
            this.Resistances += "Normal ";
        }

        /* methods */

        /* Bite: 
           Melee Weapon Attack: +8 to hit, reach 5 ft., one creature. 
           Hit: (16d5 + 3) piercing damage.
        */
        public string Bite(Creature def)
        {
            int toHit = Dice.Roll(20, 8);
            if (toHit > def.ArmorClass || toHit == 20)
            {
                int damage = Dice.Roll(4, 6, 3);
                def.HP -= damage;
                return "Couatl lunges out and bites " + def.GetType().Name +
                        " for " + damage + " piercing damage!";
            }
            else
            {
                return "Couatl fails to reach target " + def.GetType().Name + "!";
            }
        }

        /* Constrict: 
           Melee Weapon Attack: +6 to hit, reach 10 ft., one target. 
           Hit: (2d6 + 3) bludgeoning damage.
        */
        public string Constrict(Creature def)
        {
            int toHit = Dice.Roll(20, 6);
            if (toHit > def.ArmorClass || toHit == 20)
            {
                int damage = Dice.Roll(2, 6, 3);
                def.HP -= damage;
                return "Couatl wraps and constricts against " + def.GetType().Name +
                        " for " + damage + " bludgeoning damage!";
            }
            else
            {
                return "Couatl failed to tighten around the target " + def.GetType().Name + "!";
            }
        }

        public override string ToString()
        {
            return base.ToString()
                + "\nAttacks:\n  Withering Touch\n Constrict";
        }

        public override string Attack(Creature c)
        {
            if (Dice.Roll(2) == 1)
            {
                return Bite(c);
            }
            else
            {
                return Constrict(c);
            }
        }

    }

    

    
}

