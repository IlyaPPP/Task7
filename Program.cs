/* **Задача 53:** Задайте двумерный массив.
Напишите программу, которая поменяет местами первую и последнюю строку массива. 
1 4 7 2
5 9 2 3
8 4 2 4

8 4 2 4
5 9 2 3
1 4 7 2      */

int[,] array = new int[3, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write(array[i, j]);
    }
    Console.WriteLine();
}

Console.WriteLine();
int last = array.GetLength(0) - 1;

for (int i = 0; i < array.GetLength(0); i++)
{
    (array[0, i], array[last, i]) = (array[last, i], array[0, i]);
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j]);
    }
    Console.WriteLine();
}