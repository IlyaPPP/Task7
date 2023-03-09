/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка     */

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

int min = 37;
int counters = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        sum += array[i, j];
    if (min < sum) continue;
    else { min = sum; counters++; }
}
Console.WriteLine($"Наименьшая сумма элементов в строке -> {counters}");