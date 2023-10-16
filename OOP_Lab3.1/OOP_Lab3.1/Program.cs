using System;

namespace OOP_Lab3._1
{
    class Parent // Звичайний стіл
    {
        protected float pole1;

        public Parent(float pole1)
        {
            this.pole1 = pole1;
        }

        public void Print()
        {
            Console.WriteLine("Площа столу в см кв: {0}", pole1);
        }

        public float Metod()
        {
            return 3 * pole1 / 1000;
        }
    }

    class Child1 : Parent
    {
        float pole2; // Письмовий стіл

        public Child1(float pole1, float pole2) : base(pole1)
        {
            this.pole2 = pole2;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("Вартість обробки: {0}", pole2);
        }
        public float Metod()
        {
            float sum = base.Metod();
            return sum + pole2;
        }
    }

    class Child2 : Parent // Обідній стіл
    {
        string pole3;

        public Child2(string pole3, float pole1) : base(pole1)
        {
            this.pole3 = pole3;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("Форма: {0}", pole3);
        }
        public float Metod()
        {
            float sum = base.Metod();
            if (pole3 == "прямокутний")
            {
                return sum + sum * 0.1f;
            }
            if (pole3 == "овальний")
            {
                return sum + sum * 0.2f;
            }
            return sum;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // так треба
            try
            {
                Console.Write("Напишіть площу столу в см кв: ");
                float a = (Convert.ToInt32(Console.ReadLine()));
                if (a <= 0)
                {
                    Console.WriteLine("Помилка. Введено некоректні дані");
                }
                else
                {
                    float b = 1500;
                    Console.Write("Напишіть форму столу(з малої літери): ");
                    string c = (Console.ReadLine());
                    Console.WriteLine();

                    Parent pa = new Parent(a);
                    pa.Print();
                    Console.WriteLine("Звичайний стіл. Вартість: {0}", pa.Metod());
                    Console.WriteLine();

                    Child1 ch1 = new Child1(a, b);
                    ch1.Print();
                    Console.WriteLine("Письмовий стіл. Вартість: {0}", ch1.Metod());
                    Console.WriteLine();

                    Child2 ch2 = new Child2(c, a);
                    ch2.Print();
                    Console.WriteLine("Обідній стіл. Вартість: {0}", ch2.Metod());
                }
            }
            catch { Console.WriteLine("Помилка"); }
            Console.ReadKey();
        }
    }
}