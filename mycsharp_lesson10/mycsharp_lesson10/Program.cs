using System;

namespace mycsharp_lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            //string result = "";
            //Console.WriteLine("Введите число:");
            //try
            //{
            //    int a = Convert.ToInt32(Console.ReadLine()); //вводим данные, и конвертируем в целое число
            //    result = "Вы ввели число " + a;
            //}
            //catch (FormatException)
            //{
            //    result = "Ошибка. Вы ввели не число";
            //}
            //Console.WriteLine(result);

            /// Есть массив целых чисел размером 10.С клавиатуры вводится
            /// два числа -порядковые номера элементов массива, которые необходимо
            /// суммировать.Например, если ввели 3 и 5 - суммируются 3 - й и 5 - й элементы.
            /// Нужно предусмотреть случаи, когда были введены не числа, и когда одно из чисел,
            /// или оба больше размера массива.

            int[] Massive = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Введите два числа - порядковые номера элеметнов массива");

            int result = 0;
            for (int i = 0; i < 2; i++)
            {
                try
                {
                    result += Massive[Convert.ToInt32(Console.ReadLine())];
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка ввода данных");
                    return;
                }
            }

            Console.WriteLine("Результат сложения:" + result);
        }
    }
}
