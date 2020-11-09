namespace Artemkin.HomeWork._05._11
{
    class Task1
    {
        //1. Написать метод, возвращающий минимальное из трех чисел. 

        internal static double MinNumber (double first, double second, double third)
        {            
            if ( first <= second && first <= third )
            {
                return first;
            }
            else if ( second <= first && second <= third )
            {
                return second;
            }
            else
            {
                return third;
            }
        }
    }
}
