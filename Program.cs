using System;

namespace Artemkin.HomeWork._05._11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test Task1
            Console.WriteLine($"Введите первое число");
            double firstDouble = Double.Parse(Console.ReadLine());

            Console.WriteLine($"Введите второе число");
            double secondDouble = Double.Parse(Console.ReadLine());

            Console.WriteLine($"Введите третье число");
            double thirdDouble = Double.Parse(Console.ReadLine());

            Console.WriteLine($"Минимальное число из них: {Task1.MinNumber(firstDouble, secondDouble, thirdDouble)}");
            Console.ReadKey();

            //Test Task 2
            Console.Clear();
            Console.WriteLine("Введите число");
            int answer = Task2.QuantityOfNumeral(Console.ReadLine());
            Console.WriteLine($"Число состоит из {answer} цифр");
            Console.ReadKey();

            //Test Task 3
            Console.Clear();
            Task3.Start();

            //Test Task 4
            Console.Clear();
            bool logIn = Task4.LogIn();
            Console.WriteLine(logIn);
            Console.ReadKey();

            //Test Task5
            Console.Clear();
            Task5.BodyMassIndex();

            //Test Task 6
            Console.Clear();
            Task6.GoodNum();

            //Test Task 7
            //Часть а
            Console.Clear();
            int a = Task7.RNum(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.ReadKey();
            //Часть Б
            Console.Clear();
            Console.WriteLine(Task7.RSum(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
            Console.ReadKey();            
        }
    }
}
