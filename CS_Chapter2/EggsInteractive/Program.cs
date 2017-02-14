using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EggsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            int bacon;

            Console.WriteLine("Enter the Egg Number for Chicken 1: ");

            bacon = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Chicken 1 Layed {0} Eggs", bacon);



            int biscuit;

            Console.WriteLine("Enter the Egg Number for Chicken 2: ");

            biscuit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Chicken 2 Layed {0} Eggs", biscuit);



            int cereal;

            Console.WriteLine("Enter the Egg Number for Chicken 3: ");

            cereal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Chicken 3 Layed {0} Eggs", cereal);



            int milk;

            Console.WriteLine("Enter the Egg Number for Chicken 4: ");

            milk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Chicken 4 Layed {0} Eggs", milk);



            int total = bacon + biscuit + cereal + milk;



            Console.WriteLine("The Total Egg count is {0}", total);

            int dozen = 12;



            int totaldoz = (bacon + biscuit + cereal + milk) / dozen;

            int remainder = total % dozen;

            Console.WriteLine("The Total Dozens of eggs is {0} with {1} extra", totaldoz, remainder);

        }
    }
}
