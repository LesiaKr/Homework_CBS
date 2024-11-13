/*Клас Figure повинен містити конструктори, які приймають від 3 до 5 аргументів типу Point. Створити два методи: double LengthSide(Point A, Point B), що розраховує довжину сторони багатокутника; void PerimeterCalculator(), що розраховує периметр багатокутника.*/
using System.Drawing;

namespace Polygon
{
    class Figure
    {
        private Point p1, p2, p3, p4, p5;
        private int numberPoints;
        public Figure(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            numberPoints = 3;
        }
        public Figure(Point p1, Point p2, Point p3, Point p4)
            : this(p1, p2, p3)
        {
            this.p4 = p4;
            numberPoints = 4;
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
            : this(p1, p2, p3, p4)
        {
            this.p5 = p5;
            numberPoints = 5;
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.A - A.B, 2) + Math.Pow(B.A - A.B, 2));
        }
        public void PerimeterCalculator()

        {
            double perimeter = 0;
            perimeter += (LengthSide(p1, p2) * 2);
            Console.WriteLine("Периметр = " + perimeter);
        }
        public string Name
        {
            get
            {
                return "Polygon";
            }
        }
    }
}
