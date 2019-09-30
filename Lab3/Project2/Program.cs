// In the name of Allah, the Gracious, the Merciful
using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, choice;
            string condition = "";
            do
            {
                Console.WriteLine("For summing 2 numbers enter 2\n for 3 enter 3 :");
                choice = Convert.ToUInt32(Console.ReadLine());

                // getteing 2 numbers from user
                Console.Write("Enter number 1 : ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter number 2 : ");
                n2 = Convert.ToDouble(Console.ReadLine());

                
                switch (choice)
                {
                    case 2 : // if they're 2 numbers
                        if (integer(n1, n2))
                        {
                            Console.WriteLine("Sum = {0}\n", Summation.sum((int)n1, (int)n2));
                        }
                        else
                        {
                            Console.WriteLine("Sum = {0}\n", Summation.sum(n1, n2));
                        }
                        break;

                    case 3 :// if they're 3 numbers

                        // enter the 3rd number
                        Console.Write("Enter number 3 : ");
                        n3 = Convert.ToDouble(Console.ReadLine());

                        if(integer(n1, n2, n3))
                        {
                            Console.WriteLine("Sum = {0}\n", Summation.sum((int)n1, (int)n2, (int)n3));
                        }
                        else
                        {
                            Console.WriteLine("Sum = {0}\n", Summation.sum(n1, n2, n3));
                        }
                        break;
                    default : // if it is wrong choice
                        Console.WriteLine("Wrong Choice!");
                        break;
                }

                Console.WriteLine("\nDo you want to continue ? ");
                condition = Console.ReadLine();
                Console.WriteLine("\n\n");
            } while (condition != "no");
        }

        public static bool integer(double n1, double n2)
        {
            if ((n1 - (int)n1) == 0)
                if ((n2 - (int)n2) == 0)
                    return true;
            return false;
        }

        public static bool integer(double n1, double n2, double n3)
        {
            if (integer(n1, n2))
                if ((n3 - (int)n3) == 0)
                    return true;
            return false;
        }
    }
}
