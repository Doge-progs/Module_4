using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Обязательная задача*. Ввести целое число N > 0. Найти квадрат данного числа, используя для его вычисления следующую формулу: N^2=1 + 3 + 5 + ... + (2*N – 1).
После добавления к сумме каждого слагаемого выводить текущее значение суммы (в результате будут выведены квадраты всех целых чисел от 1 до N).
*/


namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число N");
            int x = Convert.ToInt32 (Console.ReadLine());
            int Sum = 0;

            Console.WriteLine("Введенное число N = {0}", x);

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine("Квадрат числа {0}", i);
                Sum = Sum + (2 * i) - 1;
                Console.WriteLine("Текущее значение суммы {0}", Sum);
                Console.WriteLine();
            }
            Console.ReadKey();
            

        }
    }
}
