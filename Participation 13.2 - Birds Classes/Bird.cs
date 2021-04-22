using System;
using System.Collections.Generic;
using System.Text;

namespace Participation_13._2___Birds_Classes
{
    class Bird
    {
        public double Height;
        public double Weight;
        public bool Gender;
        public int EggCount = 0;

        public void LaysEggs(int birdType)
        {
            if (Gender == true) // Female
            {
                if (birdType == 0) // Penguin
                {
                    Random random = new Random();
                    random.Next(0, 3);
                    EggCount = Int32.Parse(random.ToString());
                }
                else // Robin
                {
                    Random random = new Random();
                    random.Next(0, 5);
                    EggCount = Int32.Parse(random.ToString());
                }
            }

            Console.WriteLine($"EggCount: {EggCount}");

            return;
        }
    }
}
