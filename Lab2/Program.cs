using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{

    class Program
    {

        interface IPrint
        {
            void Print();
        }

        abstract class Figure
        {
            public string Type
            {
                get
                {
                    return this._Type;
                }

                protected set
                {
                    this._Type = value;
                }
            }
            string _Type;
            public abstract double Area();
        }

        class Rect : Figure, IPrint
        {
            int F1, F2;

            public Rect(int F1, int F2)
            {
                this.F1 = F1;
                this.F2 = F2;
                this.Type = "Прямоугольник";

            }

            public Rect(int F1)
            {
                this.F1 = F1;

                F2 = F1;

                this.Type = "Квадрат";

            }

            public override string ToString()
            {
                return this.Type + "\n" + "Первая сторона: " + F1 + "\n" + "Вторая сторона: " + F2 + "\n" + "Площадь равна: " + Area();
            }
            public void Print()
            {
                Console.WriteLine(ToString());
            }
            public override double Area()
            {
                return F1 * F2;
            }
        }

        class Circle : Figure, IPrint
        {
            double F1;
            public Circle(int F1)
            {
                this.F1 = F1;
                this.Type = "Круг";
            }
            public override string ToString()
            {
                return this.Type + "\n" + "Радиус " + F1 + "\n" + "Площадь круга: " +
                    Area();
            }
            public void Print()
            {
                Console.WriteLine(ToString());
            }
            public override double Area()
            {
                return 3.14 * F1 * F1;
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Выберите фигуру для которой хотите найти площадь");
            Console.WriteLine(" 1 - Круг");
            Console.WriteLine(" 2 - Прямоугольник");
            Console.WriteLine(" 3 - Квадрат");

            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Введите радиус круга:");
                    int F1 = Convert.ToInt32(Console.ReadLine());
                    Circle circle = new Circle(F1);
                    circle.Print();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Введите длину прямоугольника:");
                    int F3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите высоту прямоугольника:");
                    int F2 = Convert.ToInt32(Console.ReadLine());
                    Rect rectangle = new Rect(F3, F2);
                    rectangle.Print();
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Введите длину стороны квадрата:");
                    int F4 = Convert.ToInt32(Console.ReadLine());
                    Rect square = new Rect(F4);
                    square.Print();
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Ошибка!");
                    Console.ReadKey();
                    break;
            }
        }
    }
}