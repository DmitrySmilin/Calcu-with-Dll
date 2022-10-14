using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstLibrary;

namespace forDLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Что считаем?:circl or triangle");
            string figura = Console.ReadLine();
            if (figura == "circl")
            {
                Console.WriteLine("Считаем круг введите радиус");
                double rad = Convert.ToDouble(Console.ReadLine());
                double res_circl = MyLibrary.s_circl(rad);
                Console.WriteLine(res_circl);
            }
            else if (figura == "triangle")
            {
                Console.WriteLine("Считаем треугольник введите значение сторон");
                Console.WriteLine("a");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("b");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("c");
                double c = Convert.ToDouble(Console.ReadLine());

                if (a == b && b == c && c == a)
                { Console.WriteLine("Равнобедренный"); }
                if (a == 0 || b == 0 || c == 0)

                {
                    Console.WriteLine("Некорректный ввод");

                }
                double result = MyLibrary.s_triangle(a, b, c);
                Console.WriteLine("Sтреугольника {0}", result);
                
            }
            else
            {
                Console.WriteLine("некорректный ввод");
                Console.ReadKey();
            }
        }
    }
}
