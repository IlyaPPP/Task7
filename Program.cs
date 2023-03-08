/* **Задача 55:** Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это невозможно,
программа должна вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7      */

int[,] array = new int[4, 4];

if (array.GetLength(0) != array.GetLength(1))
{
    Console.Write($"Невозможно заменить строки на столбцы");
    return;
}
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
int[,] changeArray = new int[4, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i != j)
        {
            changeArray[i, j] = array[j, i];
            Console.Write(changeArray[i, j]);
        }
        else
        {
            changeArray[i, j] = array[i, j];
            Console.Write(changeArray[i, j]);
        }
    }
    Console.WriteLine();
}