/* Завдання 3
Потрібно: Створити клас MyMatrix, який забезпечує надання матриці довільного розміру з можливістю зміни числа рядків і стовпців. Написати програму, яка виводить на екран матрицю і похідні від неї матриці різних порядків.*/
using System;
using System.Text;

namespace MyMatrix
{
    class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            MyMatrix matrix = new MyMatrix(3, 4);
            Console.WriteLine("Оригінальна матриця:");
            matrix.PrintMatrix();

            Console.WriteLine("\nЗміна розміру матриці до 2x3:");
            matrix.ResizeMatrix(2, 3);
            matrix.PrintMatrix();

            Console.WriteLine("\nПохідна матриця 2x2:");
            SubMatrix subMatrixHandler = new SubMatrix(3, 4);
            MyMatrix subMatrix = subMatrixHandler.GetSubMatrix(2, 2);
            subMatrix.PrintMatrix();
        }
    }
}

