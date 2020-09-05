using System;

namespace mycsharp_lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massive_1 = new int[10];
            for (int i = 0; i < massive_1.Length; i++)
                massive_1[i] = i + 1; 
            int[] massive_2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] massive_res = new int[10];
            for (int i = 0; i < massive_res.Length; i++)
                Console.WriteLine("Элемент под индексом " + i + " --> " + (massive_res[i] = massive_1[i] + massive_2[i]));
        }
    }
}

/// Задача 3. Дано два массива одинаковой длины (по 10 элементов). 
/// Создайте третий массив, который будет отображать сумму первых двух массивов. 
/// Первый элемент третьего массива равен сумме первых элементов двух первых массивов и так далее.