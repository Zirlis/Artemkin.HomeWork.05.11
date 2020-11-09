using System;

namespace Artemkin.HomeWork._05._11
{
    class Task6
    {
        //6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
        //Хорошим называется число, которое делится на сумму своих цифр. 
        //Реализовать подсчет времени выполнения программы, используя структуру DateTime.
        internal static void GoodNum()
        {
            int currentNum = 0;
            int maxNum = 1_000_000_000;

            string strNum;
            int i;
            int divisor;
            bool good;
            int goodNum = 0;
            double time;
            string isGood;

            DateTime startTime = DateTime.Now;

            while ( currentNum < maxNum )
            {
                currentNum++;
                isGood = "";
                i = 0;
                divisor = 0;
                strNum = Convert.ToString(currentNum);
                char[] c = strNum.ToCharArray();

                while (i < c.Length)
                {
                    divisor += c[i];
                    i++;
                }

                good = currentNum % divisor == 0 ? true : false;
                if(good)
                {
                    isGood = " - хорошое число.";
                    goodNum++;
                }

                time = (DateTime.Now - startTime).TotalSeconds;
                Console.WriteLine($"{currentNum}{isGood} Прошло {time} сек.");
            }
            time = (DateTime.Now - startTime).TotalSeconds;
            Console.WriteLine($"Итого хороших чисел: {goodNum}. Посчитано за {time} сек.");
            Console.ReadKey();
        }
    }
}
