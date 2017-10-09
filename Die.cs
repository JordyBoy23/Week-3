using System;

namespace CupTask
{
    class Die
    {
        int sides;
        static Random rng = new Random();

        public Die (int sides)
        {
            this.sides = sides;
        }

        public int Roll(int sides)
        {
            int result = rng.Next(1, sides + 1); 
            return result;
        }
    }
}