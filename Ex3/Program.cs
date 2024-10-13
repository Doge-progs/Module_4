using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Ввести положительные числа A, B, C. На прямоугольнике размера A x B размещено максимально возможное количество квадратов со стороной C (без наложений).
Найти количество квадратов, размещенных на прямоугольнике. Операции умножения и деления не использовать.
*/

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Получение данных

            Console.WriteLine("Введите число A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число C");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введенный прямоугольник имеет стороны {0}x{1}", a, b);
            Console.WriteLine();
            #endregion

            int c_horizontal = 0; //Количество квадратов по горизонтали
            int c_vertical = 0; //Количество квадратов по вертикали
            int c_count = 0; //Количество квадратов

            if ((c > a) || (c > b))
            {
                Console.WriteLine("Число С превышает одну из сторон прямоугольника, такое решение невозможно");
                Console.ReadKey();
            }
            else
            {
                while (a >= c)
                {
                    c_horizontal++;
                    a--;

                }

                while (b >= c)
                {
                    c_vertical++;
                    b--;
                }

                Console.WriteLine("По горизонтали может быть размещено {0} квадратов", c_horizontal);
                Console.WriteLine("По вертикали может быть размещено {0} квадратов", c_vertical);
                Console.WriteLine("Общее количество квадратов путем перемножения: {0}", c_horizontal * c_vertical); //Проверка
                Console.WriteLine();


                
                while (c_horizontal > 0)
                {
                    c_count = c_count + c_vertical;
                    c_horizontal--;

                }


                
                Console.WriteLine("Общее количество квадратов путем работы цикла while: {0}", c_count);
                Console.ReadKey();
            }


        }
    }
}
