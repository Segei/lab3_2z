
using System;

namespace Lab3_2z
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            int summ =0;
            char[] c = new char[20];
            for (int i = 0; i<20; i++)
            {

                for (flag = false; flag == false;)
                {
                    Console.Write("Введите символ: ");
                    flag = char.TryParse(Console.Read(), out c[i]);
                    if (!flag)
                    {
                        Console.WriteLine("Введён не символ повторите попытку: ");
                    }
                }
            }
            foreach (char element in c)
            {
                if(element == 'x') {
                    summ++;
                }
            }
            Console.WriteLine("Сумма символов 'х' равна: " + summ);
            Console.ReadKey();
        }
    }
}
