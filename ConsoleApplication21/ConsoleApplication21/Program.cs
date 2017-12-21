using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    public enum mark
    {
        liaz, paz
    };
    class Bus
    {
        string full_name;
        int bus_number;
        int route_number;
        mark mark_bus;
        int year_of_operation;
        int mileage;

        public Bus(string n, int l, int p, mark m, int y, int t)
        {
            full_name = n;      //ФИО
            bus_number = l;       //Номер автобуса
            route_number = p;   // Номер маршрута
            mark_bus = m;           //Марка
            year_of_operation = y;   //Год эксплуатации
            mileage = t;         //Пробег   
        }
        public void setName(string n)
        {
            full_name = n;
        }
        public void setBus_number(int num)
        {
            bus_number = num;
        }
        public void setRoute_number(int num)
        {
            route_number = num;
        }
        public void setmark(mark m)
        {
            mark_bus = m;
        }
        public void setyear(int year)
        {
            year_of_operation = year;
        }
        public void setMileage(int mil)
        {
            mileage = mil;
        }
        public string getName()
        {
            return full_name;
        }
        public int getBus_number()
        {
            return bus_number;
        }
        public mark getmark()
        {
            return mark_bus;
        }
        public int getyear_of_operation()
        {
            return year_of_operation;
        }
        public int getmileage()
        {
            return mileage;
        }
        public int getroute_number()
        {
            return route_number;
        }
        public string info()
        {
            return String.Format("Водитель:{0}\tНомер автобуса:{1}\tНомер маршрута:{2}\tМарка автобуса:{3}\tГод начала эксплуатации:{4}\tПробег:{5}", full_name, bus_number, route_number, mark_bus, year_of_operation, mileage);
        }

        static void Main(string[] args)
        {
            List<Bus> elements = new List<Bus>();
            Bus one = new Bus("Иванов Иван Иванович", 1, 2, mark.liaz, 2015, 15000);
            Bus two = new Bus("Петров Петр Петрович", 2, 3, mark.paz, 2010, 17000);
            Bus three = new Bus("Петров Илья Сергеевич", 3, 4, mark.paz, 2017, 100);
            Bus four = new Bus("Петров Николай Петрович", 4, 3, mark.liaz, 2005, 1000000);
            elements.Add(one);
            elements.Add(two);
            elements.Add(three);
            elements.Add(four);

            Console.WriteLine("Введите номер маршрута");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nсписок автобусов для заданного номера маршрута:");
                bool f = false;
                for (int i = 0; i < elements.Count; i++)
                {
                    if (elements[i].getBus_number() == num)
                    {
                        Console.WriteLine(elements[i].info());
                        f = true;
                    }
                }
                if (f == false)
                {
                    Console.WriteLine("Автобусов c заданным параметром нет");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка:{0}", e);
            }
            bool k = false;
            Console.WriteLine("\nсписок автобусов, которые эксплуатируются больше 10 лет:");
            for (int i = 0; i < elements.Count; i++)
            {
                if (2017 - elements[i].getyear_of_operation() >= 10)
                {
                    Console.WriteLine(elements[i].info());
                    k = true;
                }
            }
            if (k == false)
            {
                Console.WriteLine("Автобусов c заданным параметром нет");
            }
            k = false;
            Console.WriteLine("\nсписок автобусов, пробег у которых больше 10 000 км:");
            for (int i = 0; i < elements.Count; i++)
            {

                if (elements[i].getmileage() > 10000)
                {
                    Console.WriteLine(elements[i].info());
                }

            }
            if (k == false)
            {
                Console.WriteLine("Автобусов c заданным параметром нет");
            }
        }
    }
}