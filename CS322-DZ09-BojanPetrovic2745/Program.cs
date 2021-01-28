using System;

namespace CS322_DZ09_BojanPetrovic2745
{
     class Program
    {
        static void Main(string[] args)
        {
           Zadatak1();
           Zadatak2();
           Zadatak3();

           
        }

        private static void Zadatak1()
        {
            int sum = 0;

            for (int i = 1; i <= 3000; i++)
            {
                sum += i;
            }

            Console.WriteLine("Suma je " + sum);
        }

        private static void Zadatak2()
        {
            int sum = 0;
            int curr = 2;

            for (int i = 1; i <= 100; i++)
            {
                    sum += curr;
                    curr += 2;
            }

            Console.WriteLine("Suma je: " + sum);
        }

        private static void Zadatak3()
        {
            for (int i = 21; i <99; i++)
            {
                if (i % 2 ==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    } 
}
