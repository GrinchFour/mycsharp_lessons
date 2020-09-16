using System;
using System.Collections.Generic;

namespace mycsharp_lesson12
{

    public class Car
    {
        private int wheels;
        public string model;
        private string transmission;

        public Car()
        {
            wheels = 2;
            model = "Harwi";
            transmission = "full";
        }

        public Car(int wheels, string model, string transmission)
        {
            this.wheels = wheels;
            this.model = model;
            this.transmission = transmission;
        }

        public int Wheels
        {
            get
            {
                return wheels;
            }
            set
            {
                if (value < 1)
                    wheels = 1;
                else wheels = value;
            }
        }
    }

    public class TV
    {
        private uint volume;

        public TV()
        {
            volume = 0;
        }

        public TV(uint volume)
        {
            this.volume = volume;
        }

        public uint Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value > 100)
                    volume = 100;
                else volume = value;
            }
        }
    }

    public class watchTV : TV
    {
        private uint thisChannel;

        public watchTV()
        {
            thisChannel = 0;
        }

        public watchTV(uint thisChannel, uint volume) : base(volume)
        {
            this.thisChannel = thisChannel;
        }

        public void nowChannel()
        {
            Console.WriteLine("Текущий канал: " + thisChannel);
        }

        public void nextChannel()
        {
            thisChannel++;
            nowChannel();
        }

        public void previousChannel()
        {
            if (thisChannel > 0)
                thisChannel--;
            nowChannel();
        }

        public void putChannel(uint newChannel)
        {
            thisChannel = newChannel;
            nowChannel();
        }
    }

    public class playTV : TV
    {
        private bool gameBoost;

        public playTV()
        {
            gameBoost = true;
        }

        public playTV(bool gameBoost, uint volume) : base(volume)
        {
            this.gameBoost = gameBoost;
        }

        public void helpGameBoost()
        {
            if (gameBoost)
                Console.WriteLine("Телевизор в режиме \"для игр\"");
            else Console.WriteLine("Режим \"для игр\" отключен");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Работа с классом: ");

            Car car_1 = new Car();
            car_1.Wheels = 4;
            car_1.model = "Nissan";

            Car car_2 = new Car();
            car_2.Wheels = 6;
            car_2.model = "Mercedes";

            Console.WriteLine(car_2.model);
            Console.WriteLine();

            Console.WriteLine("Работа с методами в классе: ");

            watchTV myTV_1 = new watchTV();
            myTV_1.nowChannel();
            myTV_1.previousChannel();
            myTV_1.putChannel(55);
            myTV_1.previousChannel();
            myTV_1.putChannel(0);
            myTV_1.nextChannel();
            myTV_1.nowChannel();
            Console.WriteLine();

            Console.WriteLine("Работа со свойствами в классе: ");

            myTV_1.Volume = 150;
            Console.WriteLine(myTV_1.Volume);
            Console.WriteLine();

            Console.WriteLine("Работа с наследованиями в классов: ");

            playTV myTV_2 = new playTV();
            myTV_2.helpGameBoost();

            playTV myTV_3 = new playTV(false, 66);
            Console.WriteLine("Текущее значение громкости в игре: " + myTV_3.Volume);
            myTV_3.helpGameBoost();
            Console.WriteLine();

            Console.WriteLine("Работа с указателями на базовый класс: ");

            List<TV> myTVs = new List<TV>();
            myTVs.Add(new playTV(false, 11));
            myTVs.Add(new watchTV(22, 22));
            myTVs.Add(new playTV(true, 33));

            foreach (TV tv in myTVs)
            {
                Console.WriteLine("Громкость: " + tv.Volume);
            }
            Console.WriteLine();

            Console.WriteLine("Смотреть телевизор - это играть через телевизор? - " + (myTV_1 is playTV));
            Console.WriteLine("Смотреть телевизор - это смотреть телевизор? - " + (myTV_1 is watchTV));
            Console.WriteLine("Смотреть телевизор - пользоваться телевизором? - " + (myTV_1 is TV));
            Console.WriteLine();

            int i = 0;
            foreach (TV tv in myTVs)
            {
                i++;
                Console.Write("Телевизор " + i + " : ");
                if (tv is playTV)
                    ((playTV)tv).helpGameBoost();
                else
                    ((watchTV)tv).nowChannel();
            }
            Console.WriteLine();

            i = 0;
            foreach (TV tv in myTVs)
            {
                i++;
                Console.Write("Телевизор " + i + " : ");
                if (tv is playTV)
                    (tv as playTV).helpGameBoost();
                else
                    (tv as watchTV).nowChannel();
            }
        }
    }
}