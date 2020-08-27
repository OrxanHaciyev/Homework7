using System;

namespace zadaniye3
{
    class Program
    {
        static void Main(string[] args)
        {

            bool c = false;
            int num;
            int step = 0;
            do
            {
                Console.WriteLine("введите число");
                if (Int32.TryParse(Console.ReadLine(), out num) && (num > 0))
                {

                }
                else
                {
                    Console.WriteLine("неверный ввод ,введите снова");
                    continue;
                }
                Console.WriteLine("введите степень числа");
                if (Int32.TryParse(Console.ReadLine(), out step) && (step > 0))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("неверный ввод ,введите снова");
                    continue;
                }
            } while (c == false);




            int result = Stepen(num, step);
            Console.WriteLine(result);
        }
        static int Stepen(int a, int b)
        {

            if (b == 0)
            {

                return 1;
            }
            else
            {
                return a * Stepen(a, b - 1);
            }

        }
    }
}
