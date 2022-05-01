using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Vetters
{
    class PlayerCharacter : Creature
    {

        public PlayerCharacter() : base()
        {
            int[] dice = new int[4];

            for (int die = 0; die < dice.Length; die++)
            {
                dice[die] = Dice.Roll(6);
            }
            this.Strength = dice.Sum() - dice.Min();

            for (int die = 0; die < dice.Length; die++)
            {
                dice[die] = Dice.Roll(6);
            }
            this.Dexterity = dice.Sum() - dice.Min();

            for (int die = 0; die < dice.Length; die++)
            {
                dice[die] = Dice.Roll(6);
            }
            this.Constitution = dice.Sum() - dice.Min();

            for (int die = 0; die < dice.Length; die++)
            {
                dice[die] = Dice.Roll(6);
            }
            this.Intelligence = dice.Sum() - dice.Min();

            for (int die = 0; die < dice.Length; die++)
            {
                dice[die] = Dice.Roll(6);
            }
            this.Wisdom = dice.Sum() - dice.Min();

            for (int die = 0; die < dice.Length; die++)
            {
                dice[die] = Dice.Roll(6);
            }
            this.Charisma = dice.Sum() - dice.Min();

            this.HP = 10 + (this.Constitution - 10) / 2;

            this.ArmorClass = 10 + (this.Dexterity - 10) / 2;

        }

        public override string Attack(Creature defender)
        {
            return ""; // add in attacks
        }

    }
}
