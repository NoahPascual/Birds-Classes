using System;
using System.Collections.Generic;
using System.Text;

namespace Participation_13._2___Birds_Classes
{
    class Penguin
    {
        public double SwimDepthMax;
        public double UnderwaterMinutes;

        public double Height;
        public double Weight;

        public double CalculateUnderwater()
        {
            return (Height * Weight) / 1860;
        }

    }
} 
