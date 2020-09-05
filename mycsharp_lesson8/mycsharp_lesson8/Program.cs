using System;

namespace mycsharp_lesson8
{
    class Program
    {
        public static void ReplaceName(string[] names, string name, string newName)
        {
            for (int i = 0; i < names.Length; i++)
                if (names[i] == name) names[i] = newName;
        }

        static void Main(string[] args)
        {
            string[] names = { "Sergey", "Maxim", "Andrey", "Oleg", "Andrey", "Ivan", "Sergey" };

            ReplaceName(names, "Andrey", "Nikolay");
            ReplaceName(names, "Ivan", "Vladimir");
            for (int i = 0; i < names.Length; i++)
                Console.Write(names[i] + ' ');
        }
    }
}
