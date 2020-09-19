using System;
using System.Collections.Generic;

namespace mycsharp_lesson21
{
    abstract class Human
    {
        public string name;
        public abstract void Greeting();
    }

    class Russian : Human
    {
        public Russian(string name)
        {
            this.name = name;
        }

        public override void Greeting()
        {
            Console.WriteLine("Русский " + name + " сказал \"Привет!\"");
        }
    }

    class Ukrainian : Human
    {
        public Ukrainian(string name)
        {
            this.name = name;
        }

        public override void Greeting()
        {
            Console.WriteLine("Украинец " + name + " сказал \"Привiт!\"");
        }
    }

    class American : Human
    {
        public American(string name)
        {
            this.name = name;
        }

        public override void Greeting()
        {
            Console.WriteLine("Американец " + name + " сказал \"Hello!\"");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Human> humans = new List<Human>();
            humans.Add(new Russian("Иннокентий"));
            humans.Add(new Ukrainian("Лёша"));
            humans.Add(new American("Johnny"));

            foreach (Human h in humans)
            {
                h.Greeting();
            }
        }
    }
}

//    Создайте абстрактный класс Человек,
//    пусть там будет свойство Имя и
//    абстрактный метод СказатьПриветствие(),
//    от этого класса будет несколько наследников,
//    которые представляют национальность(русский, украинец, американец...).
//    Должно получиться так, что при вызове метода СказатьПриветствие()
//    выводилось приветствие на языке соответствующему
//    национальности(Привет, Привіт, Hi...).
