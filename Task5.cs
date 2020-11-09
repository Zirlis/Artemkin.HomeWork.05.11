using System;


namespace Artemkin.HomeWork._05._11
{
    class Task5
    {
        //5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
        //нужно ли человеку похудеть, набрать вес или все в норме; 
        //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        internal static void BodyMassIndex()
        {
            //часть А
            string stringHeigth;
            float heigth;
            do
            {
                Console.WriteLine("Введите ваш рост");
                stringHeigth = Console.ReadLine();
            } while (!float.TryParse(stringHeigth, out heigth) || heigth > 250);
            if (heigth > 50)
            {
                heigth /= 100; //перевод сантиметров в метры при необходимости
            }

            string stringWeigth;
            float weigth;
            do
            {
                Console.WriteLine("Введите ваш вес");
                stringWeigth = Console.ReadLine();
            } while (!float.TryParse(stringWeigth, out weigth) || weigth > 250);

            double bodyMassIndex = Math.Round(weigth / (heigth * heigth), 1);

            Console.WriteLine($"Ваш индекс массы тела = {bodyMassIndex}");

            //Часть Б
            double recomendedMin = 18.5;
            int recomendedMax = 25;

            if(bodyMassIndex < 18.5)
            {
                int massUp1 = (int)(recomendedMin * (heigth * heigth) - weigth);
                int massUp2 = (int)(recomendedMax * (heigth * heigth) - weigth);

                Console.WriteLine($"Вам стоит набрать {massUp1} - {massUp2} кг");
            }
            else if(bodyMassIndex > 25)
            {
                int massDown1 = (int)(weigth - (recomendedMax * (heigth * heigth)));
                int massDown2 = (int)(weigth - (recomendedMin * (heigth * heigth)));

                Console.WriteLine($"Вам стоит сбросить {massDown1} - {massDown2} кг");
            }
            else
            {
                Console.WriteLine("Ваш вес в норме");
            }
            Console.ReadKey();
        }
    }
}
