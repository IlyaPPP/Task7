/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18    */

int[,] matrix1 = createMatrix(4, 4);   // первая матрица

int[,] createMatrix(int a, int b)
{
    int[,] matrix = new int[a, b];
    for (int i = 0; i < a; i++) // цикл for для заполнения двухмерного массива
    {                                            // рандомными числами
        for (int j = 0; j < b; j++)
        {
            matrix[i, j] = new Random().Next(10);
            Console.Write(matrix[i, j]);
        }
        Console.WriteLine();
    }
    return matrix;
}

Console.WriteLine();            // разделитель

int[,] matrix2 = createMatrix(4, 4);   // вторая матрица

productMatrix();

void productMatrix()     // функция выполняющая умножение двух матриц
{

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix2[i, j] *= matrix1[i, j];
            Console.Write($"{matrix2[i, j]}  ");
        }
        Console.WriteLine();
    }
}