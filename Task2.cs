namespace Artemkin.HomeWork._05._11
{
    class Task2
    {
        //2. Написать метод подсчета количества цифр числа. 
        internal static int QuantityOfNumeral(string num)
        {
            int numeral = 0;
            char[] c = num.ToCharArray();
            int i = 0;

            while (i < c.Length)
            {
                if (c[i] != ',' && c[i] != '-')
                {
                    numeral++;
                }
                i++;
            }
            return numeral;
        }
    }
}
