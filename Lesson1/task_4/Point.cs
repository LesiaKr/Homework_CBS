/*Потрібно: Створити класи Point та Figure. Клас Point повинен містити два цілих поля і одне рядкове поле. Створити три властивості одним методом доступу get. Створити власний конструктор, у тілі якого проініціалізуйте поля значеннями аргументів. */
namespace Polygon
{
    class Point
    {
        int a, b;
        string name;

        public int A
        {
            get { return a; }
        }

        public int B
        {
            get { return b; }
        }

        public string Name
        {
            get { return name; }
        }
        public Point(int a, int b, string name)
        {
            this.a = a;
            this.b = b;
            this.name = name;
        }
    }
}
