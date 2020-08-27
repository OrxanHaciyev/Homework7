using System;

namespace zadaniye2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 2: Написать рекурсивную функцию нахождения наибольшего общего делителя двух целых чисел.
            int a = 0;
            int b = 0;
            bool c = false;
            do
            {
                Console.WriteLine("введите первое число");
                if (Int32.TryParse(Console.ReadLine(), out a) && (a > 0))
                {

                }
                else
                {
                    Console.WriteLine("неверный ввод ,введите снова");
                    continue;
                }
                Console.WriteLine("введите второе число");
                if (Int32.TryParse(Console.ReadLine(), out b) && (b > 0))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("неверный ввод ,введите снова");
                    continue;
                }
            } while (c == false);

            int y = Nod(a, b);
            Console.WriteLine(y);
            int Nod(int a, int b)
            {
                if (b == 0)
                    return a;
                if (a > b)
                    return Nod(b, a % b);
                else
                    return Nod(a, b % a);
            }
        }
    }
}
