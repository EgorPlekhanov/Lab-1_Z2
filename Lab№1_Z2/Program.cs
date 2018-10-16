using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0;
            bool ok = true;
            do
                try
                {
                    Console.WriteLine("Введите координаты точки:");
                    Console.Write("x = ");
                    x = double.Parse(Console.ReadLine());
                    Console.Write("y = ");
                    y = double.Parse(Console.ReadLine());
                    bool res = (y >= Math.Abs(x) - 5 && y <= 0) || (y <= -x + 5 && 0 <= y && y <= 5 && x >= 0);
                    if (res)
                        Console.WriteLine("Точка принадлежит выделенному фрагменту");
                    else
                        Console.WriteLine("Точка не принадлежит выделенному фрагменту");
                    ok = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неправильно введено число!\n");
                    ok = false;
                }
            while (!ok);
        }
    }
}
