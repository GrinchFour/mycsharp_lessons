using System;

/// Идейное объяснение многомерного массива

namespace mycsharp_lesson9
{
    class Program
    {
        static void Message1()
        {
            Console.WriteLine("Для начала стоит вспомнить, что индексация в массивах в языке C# начинается с нуля!");
            Console.WriteLine();
        }

        static void Message2()
        {
                Console.Write("Выводим элементы одномерного массива: ");
        }

        static void Message3()
        {
            Console.Write("Начнём, элемент этого массива, находящийся под индексом 1: ");                                       
        }

        static void Message4()
        {
            Console.Write("Перевод этого элемента (строки) в массив символов" +
                              " и вывод символа под индексом 1: " );
        }

        static void Message5()
        {
            Console.Write("Теперь мы прошлый выведенный символ" +
                             " преобразовали в двоичный вид: ");
        }

        static void Message6()
        {
            Console.Write("Для наглядности выведем цифру" +
                              " двоичного кода под индексом 1: ");
        }

        static void Message7()
        {
            Console.Write("И под индексом 2: ");
        }

        static void Main(string[] args)
        {
            string[] s = { "Hello", "World" };

            Console.WriteLine("Message1: ");
            Message1();

            Console.WriteLine("Message2: ");
            for (int i = 0; i < s.Length; i++)                                // Выводим весь одномерный массив  
            {
                Message2();
                Console.WriteLine(s[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Message3: ");                                  // Выводим элемент, с которым в дальнейшем 
            Message3(); ;                                                     // будем работать                                     
            Console.WriteLine(s[1]);
            Console.WriteLine();

            Console.WriteLine("Message4: ");
            Message4();
            Console.WriteLine(s[1].ToCharArray()[1]);                         // Перевели прошлую строку в массив char'ов и                                     
            Console.WriteLine();                                              // вывели символ под 1-м индексом

            Console.WriteLine("Message5: ");
            Message5();
            Console.WriteLine(Convert.ToString(s[1].ToCharArray()[1], 2));    // То же самое, что и в прошлом пункте, только                                   
            Console.WriteLine();                                              // получившийся символ представили в двоичном виде    
            
            Console.WriteLine("Message6: ");
            Message6();       
            Console.WriteLine(Convert.ToString(s[1].ToCharArray()[1], 2)[1]); // Вывели 1-й индекс символа, представленного в 
            Console.WriteLine();                                              // двоичном виде

            Console.WriteLine("Message7: ");
            Message7();                                                   
            Console.Write(Convert.ToString(s[1].ToCharArray()[1], 2)[2]);     // Вывели 2-й индекс для наглядности           
        }
    }
}
