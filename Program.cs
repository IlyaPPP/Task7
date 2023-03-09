/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2     */

int[,] array = new int[3, 4];               // двухмерный массив 
for (int i = 0; i < array.GetLength(0); i++)            // цикл для заполнения массива рандомными цифрами 
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write(array[i, j]);
    }
    Console.WriteLine();
}

int s = 0;              // счетчик выполнения рекурсии
int x = 0;              // счетчик переключения строк

Sorted();
void Sorted(int d = 0)              // функция сортировки 
{
    s++;
    if (s > array.GetLength(1))         // условие выхода из рекурсии
    {
        x++;
        s = 0;
        return;
    }
    else
    {
        for (int j = array.GetLength(1) - 1; j > 0; j--)
        {
            d = x;
            if (array[d, j - 1] < array[d, j])      // условие выполнение сортировки
                (array[d, j - 1], array[d, j]) = (array[d, j], array[d, j - 1]);  // сортировка
        }
        Sorted();   // вызов рекурсии. В данном случае она нужна, для повторного сравнения числовых пар
    }
}
Sorted();               // вызов функции для сортировки второй строки
Sorted();               // повторный вызов функции для сортировки третьей строки`

Console.WriteLine($"{array[0, 0]}, {array[0, 1]}, {array[0, 2]}, {array[0, 3]}");
Console.WriteLine($"{array[1, 0]}, {array[1, 1]}, {array[1, 2]}, {array[1, 3]}");
Console.WriteLine($"{array[2, 0]}, {array[2, 1]}, {array[2, 2]}, {array[2, 3]}");
