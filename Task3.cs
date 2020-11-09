using System;

namespace Artemkin.HomeWork._05._11
{
    class Task3
    {
        //3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        internal static void Start()
        {
            Console.WriteLine("Введите множество чисел.");
            Console.WriteLine("Чтобы подсчитать сумму всех нечетных положительных чисел введите 0");
            int num;
            string strNum;
            int summ = 0;
            do
            {
                strNum = Console.ReadLine();
                if(Int32.TryParse(strNum, out num) && num % 2 ==1 && num > 0)
                {
                    summ += num;
                }
            } while (num != 0);
            Console.WriteLine($"Сумма ровна: {summ}");
            Console.ReadKey();
        }
    }
}
