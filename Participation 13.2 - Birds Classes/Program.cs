using System;
using System.Collections.Generic;

namespace Participation_13._2___Birds_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Robin robin1 = new Robin();
            robin1.Height = 6;
            robin1.Weight = 20;
            Robin robin2 = new Robin();
            robin2.Height = 5;
            robin2.Weight = 16;

            Penguin penguin1 = new Penguin();
            penguin1.Height = 48;
            penguin1.Weight = 50;
            Penguin penguin2 = new Penguin();
            penguin2.Height = 45;
            penguin2.Weight = 48;

            Console.WriteLine("What is the gender of penguin 1? (0 = male, 1 = female)");
            int gender1 = Int32.Parse(Console.ReadLine());
            if (gender1 == 0)
            {
                robin1.Gender = false;
            }
            else
            {
                robin1.Gender = true;
            }

            Console.WriteLine("What is the gender of penguin 1? (0 = male, 1 = female)");
            int gender2 = Int32.Parse(Console.ReadLine());
            if (gender2 == 0)
            {
                robin1.Gender = false;
            }
            else
            {
                robin1.Gender = true;
            }

            Console.WriteLine("What is the gender of penguin 1? (0 = male, 1 = female)");
            int gender3 = Int32.Parse(Console.ReadLine());
            if (gender3 == 0)
            {
                robin1.Gender = false;
            }
            else
            {
                robin1.Gender = true;
            }

            Console.WriteLine("What is the gender of penguin 1? (0 = male, 1 = female)");
            int gender4 = Int32.Parse(Console.ReadLine());
            if (gender4 == 0)
            {
                robin1.Gender = false;
            }
            else
            {
                robin1.Gender = true;
            }

            Console.WriteLine($"Robin 1 Windspan: {robin1.CalculateWingspan()}");
            Console.WriteLine($"Robin 2 Windspan: {robin2.CalculateWingspan()}");

            Console.WriteLine($"Penguin 1 UW : {penguin1.CalculateUnderwater():N2} minutes long");
            Console.WriteLine($"Penguin 2 UW : {penguin2.CalculateUnderwater():N2} minutes long");

            Console.ReadKey();
        }
    }
}
