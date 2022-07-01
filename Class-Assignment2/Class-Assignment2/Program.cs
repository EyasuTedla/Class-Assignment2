using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool repeat = false;
            int answer = 0;

            Test obj = new Test();

            obj.disp();

            do
            {
                Console.WriteLine("Do you want to input again? ___ (0 for Yes, other for no) -> ");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == 0)
                {
                    obj.disp();
                }
                else
                {
                    Console.WriteLine("Wrong input try again");
                }
            } while (answer != 0);
            Console.ReadKey();


        }

        class Test
        {
            public void disp()
            {
                int num;
                Console.WriteLine("Enter a whole number less than 21: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("You entered an even number");
                }
                else
                {
                    Console.WriteLine("You entered an odd number");
                }
            }
        }
    }
}

/*
 * do
{
    if (num / 2 = 0)
    {
        Console.WriteLine("Wrong input! please enter again");
        num = Convert.ToInt32(Console.ReadLine());
    }
} while (num > 0 || num < 21);
*/