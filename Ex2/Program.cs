using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*
Осуществить ввод последовательности целых чисел и сравнить, что больше, количество положительных или количество отрицательных.
Последовательность потенциально не ограничена, окончанием последовательности служит число 0.
*/
namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int Counter = 0;
            int y = 0;
            
            do
            {
                Console.WriteLine("Введите число");
                x = Convert.ToInt32(Console.ReadLine());
                if (x > 0)
                {
                    Counter++;
                }
                if (x < 0)
                {
                    Counter--;
                }

                y++;

                Console.WriteLine("В последовательности {0} чисел", y);
                Console.WriteLine();

            } while (x != 0);



            if (Counter > 0)
            {
                Console.WriteLine("Положительных чисел больше");
            }
            if (Counter < 0)
            {
                Console.WriteLine("Отрицательных чисел больше");
            }
            if (Counter == 0)

            {
                Console.WriteLine("Положительных и отрицательных чисел одинаковое количество");
            }
            Console.ReadKey();


        }
    }
}
