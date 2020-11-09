using System;

namespace Artemkin.HomeWork._05._11
{
    class Task7
    {
        //7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
        //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

        //Часть а
        internal static int RNum(int a, int b)
        {
            if(b >= a)
            {
                Console.WriteLine(RNum(a, b - 1) + 1);
            }
            return b;
        }

        //Часть б
        internal static int RSum(int a, int b)
        {
            if(b == a)
            {
                return a;
            }
            else
            {
                return RSum(a, b - 1) + b;
            }
        }
    }
}
