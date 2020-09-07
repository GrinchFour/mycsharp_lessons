using System;
using System.IO;
using System.Text;

namespace mycsharp_lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Colors = { "red", "green", "black", "white", "blue" };
            Directory.CreateDirectory("testColors");
            FileStream file1W = new FileStream("testColors\\test1.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writerFile1 = new StreamWriter(file1W);
            for (int i = 0; i < Colors.Length; i++)
                writerFile1.WriteLine(Colors[i]);
            writerFile1.Close();
            // Если заменить "FileMode.Create" на "FileMode.CreateNew", то
            // при запуске во второй раз указывает на то, что файл уже был создан.
            // Заодно можно узнать и путь, где он находится.

            FileStream file1R = new FileStream("testColors\\test1.txt", FileMode.Open, FileAccess.Read);
            StreamReader readerFile1 = new StreamReader(file1R);
            int str = 0;
            int buffStr = 0;
            while (!readerFile1.EndOfStream)
            {
                buffStr = readerFile1.ReadLine().Length;
                if (buffStr > str)
                    str = buffStr;
            }
            readerFile1.Close();

            FileStream file2W = new FileStream("testColors\\test1.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writerFile2 = new StreamWriter(file2W);
            writerFile2.WriteLine("Самая длинная строка длиной: " + Convert.ToString(str));
            writerFile2.Close();
        }
    }
}

/// Задача 2. Дан массив строк: "red", "green", "black", "white", "blue". 
/// Запишите в файл элементы массива построчно (каждый элемент в новой строке).
/// 
/// Задача 3. Возьмите любой текстовый файл, и найдите в нем размер самой длинной строки.