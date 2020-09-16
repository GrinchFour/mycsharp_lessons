using System;
using System.Collections.Generic;

namespace mycsharp_lesson20
{
    class Unit
    {
        public uint hP { get; set; }

        public Unit()
        {
            hP = 100;
        }

        public virtual void takeDamage(uint damage)
        {
            if (hP > damage)
            {
                hP -= damage;
                Console.WriteLine("Полученный урон: " + damage);
            }
            else
            {
                hP = 0;
                Console.WriteLine("Юнит уничтожен . . .");
            }
        }

        public virtual void infoUnit()
        {
            Console.WriteLine("Текущее сзначение хп: " + hP);
            Console.WriteLine("Коэффициент защиты: 0");
        }
    }

    class Warrior : Unit
    {
        public override void takeDamage(uint damage)
        {
            Console.WriteLine("Текущий юнит: Воин");
            damage -= (uint)Math.Ceiling(0.1 * damage);
            base.takeDamage(damage);
        }

        public override void infoUnit()
        {
            Console.WriteLine("Осталось хп: " + hP);
            Console.WriteLine("Коэффициент защиты: 0.1");
        }
    }

    class Warrior_L : Unit
    {
        public override void takeDamage(uint damage)
        {
            Console.WriteLine("Текущий юнит: Воин в лёгких доспехах");
            damage -= (uint)Math.Ceiling(0.3 * damage);
            base.takeDamage(damage);
        }

        public override void infoUnit()
        {
            Console.WriteLine("Осталось хп: " + hP);
            Console.WriteLine("Коэффициент защиты: 0.3");
        }
    }

    class Warrior_H : Unit
    {
        public override void takeDamage(uint damage)
        {
            Console.WriteLine("Осталось хп: " + hP);
            damage -= (uint)Math.Floor(0.7 * damage);
            base.takeDamage(damage);
        }

        public override void infoUnit()
        {
            Console.WriteLine("Осталось хп: " + hP);
            Console.WriteLine("Коэффициент защиты: 0.7");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Unit> army = new List<Unit>();
            army.Add(new Warrior());
            army.Add(new Warrior_L());
            army.Add(new Warrior_H());

            foreach (Unit armyDamage in army)
            {
                if (armyDamage is Warrior)
                {
                    (armyDamage as Warrior).takeDamage(90);
                    (armyDamage as Warrior).infoUnit();
                    Console.WriteLine();
                }
                else if (armyDamage is Warrior_L)
                {
                    (armyDamage as Warrior_L).takeDamage(90);
                    (armyDamage as Warrior_L).infoUnit();
                    Console.WriteLine();
                }
                else
                {
                    (armyDamage as Warrior_H).takeDamage(90);
                    (armyDamage as Warrior_H).infoUnit();
                    Console.WriteLine();
                }
            }
        }
    }
}

// создайте три класса: воин, воин_в_легких_доспехах и воин_в_тяжелых_доспехах.
// у всех них есть свойство – количество_жизней, а также метод получить_урон,
// который принимает в качестве аргумента значение получаемого урона.
// реализуйте этот метод по-разному для всех типов, установив различные
// коэффициенты в зависимости от типа доспехов в формуле вычета здоровья.