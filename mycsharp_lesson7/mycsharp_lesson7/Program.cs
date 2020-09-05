using System;

namespace mycsharp_lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massive = { 2, 34, 21, 432, 12, 43, 345, 567, 234, 23, 546 };
            foreach (int el in massive) if (el > 20 && el < 50) Console.WriteLine(el);
        }
    }
}

/// Используя цикл foreach, выведите на экран все элементы массива целых чисел, которые больше 20 и меньше 50.