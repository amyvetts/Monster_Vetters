using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Vetters
{
    abstract class Creature
    {
        /* Fields */

        private int[] attributes;

        /* Properties */

        public int HP { get; set; }
        public int ArmorClass { get; protected set; }
        public bool Darkvision { get; protected set; }
        /* Resistances are handled as a single string.
           In the future, we will alter this to be more
           robust and usable.
        */
        public string Resistances { get; protected set; }
        public int Strength
        {
            get
            {
                return attributes[0];
            }

            protected set
            {
                attributes[0] = value;
            }
        }

        public int Dexterity
        {
            get
            {
                return attributes[1];
            }

            protected set
            {
                attributes[1] = value;
            }
        }

        public int Constitution
        {
            get
            {
                return attributes[2];
            }

            protected set
            {
                attributes[2] = value;
            }
        }

        public int Intelligence
        {
            get
            {
                return attributes[3];
            }

            protected set
            {
                attributes[3] = value;
            }
        }

        public int Wisdom
        {
            get
            {
                return attributes[4];
            }

            protected set
            {
                attributes[4] = value;
            }
        }

        public int Charisma
        {
            get
            {
                return attributes[5];
            }

            protected set
            {
                attributes[5] = value;
            }
        }



        /* Constructors */

        public Creature()
        {
            this.attributes = new int[6];
            this.Darkvision = false;
            this.HP = 0;
            this.Resistances = "";
        }

        /* methods */

        public override string ToString()
        {
            string output =
                this.GetType().Name +
                "\n============" +
                "\nSTR: " + this.Strength +
                "\nDEX: " + this.Dexterity +
                "\nCON: " + this.Constitution +
                "\nINT: " + this.Intelligence +
                "\nWIS: " + this.Wisdom +
                "\nCHA: " + this.Charisma +
                "\n============" +
                "\nHP: " + this.HP +
                "\nAC: " + this.ArmorClass +
                "\nResistances: " + this.Resistances +
                "\n============" +
                "\nDarkvision: " + this.Darkvision + "\n";
            return output;
        }
        // specify attacks in subclass
        public abstract string Attack(Creature c);
    }
}
