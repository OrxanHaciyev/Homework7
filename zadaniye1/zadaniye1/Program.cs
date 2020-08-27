using System;

namespace zadaniye1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int result = Summ(10);
                Console.WriteLine("сумма чисел степеней");
                Console.WriteLine(result);
            }
            static int Summ(int n)
            {

                int a = Rec(n);


                if (n == 2)
                {

                    return 4;
                }
                else
                {
                    return a + Summ(n - 1);

                }
                static int Rec(int n)
                {


                    if (n == 1)
                    {
                        return 2;
                    }
                    else
                    {
                        return 2 * Rec(n - 1);
                    }
                }
            }
        }
    }
}
