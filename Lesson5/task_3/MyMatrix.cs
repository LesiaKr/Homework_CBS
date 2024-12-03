/* Завдання 3
Потрібно: Створити клас MyMatrix, який забезпечує надання матриці довільного розміру з можливістю зміни числа рядків і стовпців. Написати програму, яка виводить на екран матрицю і похідні від неї матриці різних порядків.*/
using System;

namespace MyMatrix
{
    public class MyMatrix
    {
        public int[,] matrix;
        public int rows;
        public int columns;

        public MyMatrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            matrix = new int[rows, columns];
        }

        public void ResizeMatrix(int newRows, int newColumns)
        {
            this.rows = newRows;
            this.columns = newColumns;
            this.matrix = new int[newRows, newColumns];
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = 1;
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
