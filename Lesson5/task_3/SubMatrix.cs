/* Завдання 3
Потрібно: Створити клас MyMatrix, який забезпечує надання матриці довільного розміру з можливістю зміни числа рядків і стовпців. Написати програму, яка виводить на екран матрицю і похідні від неї матриці різних порядків.*/
using System;

namespace MyMatrix
{
    public class SubMatrix : MyMatrix
    {
        public SubMatrix(int rows, int columns) : base(rows, columns) { }
        public MyMatrix GetSubMatrix(int newRows, int newColumns)
        {
            MyMatrix subMatrix = new MyMatrix(newRows, newColumns);
            for (int i = 0; i < newRows; i++)
            {
                for (int j = 0; j < newColumns; j++)
                {
                    if (i < this.rows && j < this.columns)
                    {
                        subMatrix.matrix[i, j] = this.matrix[i, j];
                    }
                }
            }
            return subMatrix;
        }
    }
}
