using System;

namespace zadaniye5
{
    enum Week
    {
        Monday=1 ,
        Tuesday = 2,
        Wednsday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7

    }
    class Program
    {
        static void Main(string[] args)
        {
            Week day;
            int num = tryparse();
            
            switch (num)
            {

                default:
                case 1:
                    day = Week.Monday;
                    break;
                case 2:
                    day = Week.Tuesday;
                    break;
                case 3:
                    day = Week.Wednsday;
                    break;
                case 4:
                    day = Week.Thursday;
                    break;
                case 5:
                    day = Week.Friday;
                    break;
                case 6:
                    day = Week.Saturday;
                    break;
                case 7:
                    day = Week.Sunday;
                    break;
               


            }
            Console.WriteLine($"{day}");
        }


        
        static int tryparse()
        {
            int num1;
            bool triger = false;
            do
            {
                Console.WriteLine($"введите  от 1 до 7");
                if (int.TryParse(Console.ReadLine(), out num1) && ((num1 > 0) && (num1 < 8)))
                {
                    triger = true;
                }
                else
                {
                    Console.WriteLine("неправильно введите число заново");
                    continue;
                }
            }
            while (triger == false);
            return num1;
        }
    }
}
