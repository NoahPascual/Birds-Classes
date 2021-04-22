using System;
using System.Collections.Generic;
using System.Text;

namespace Participation_13._2___Birds_Classes
{
    class Robin : Bird
    {
        public double FlightSpeed;

        public double CalculateWingspan()
        {
            return Height * 1.67;
        }

    }
}
