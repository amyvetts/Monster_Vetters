using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Vetters
{
    abstract class MediumCelestial : Creature
    {
        /* Fields */
        /* Properties */
        /* Constructors */

        public MediumCelestial() : base()
        {
            this.Darkvision = false;
            this.Resistances += "Truesight ";
        }
        /* Methods */
    }
}
