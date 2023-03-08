/* **Задача 57:** Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том,
сколько раз встречается элемент входных данных.
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза    */

int[,] array = new int[4, 4];   // двухмерный массив

for (int i = 0; i < array.GetLength(0); i++) // цикл for для заполнения двухмерного массива
{                                            // рандомными числами
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write(array[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine();

int number = 0;
int count = 0;
findCount(number);

void findCount(int number)     // функция для подсчета количества символов в двухмерном массиве
{
    if (number >= 10)
        return;
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] != number)
                    if (array[i, j] == array.GetLength(0) - 1 && array[i, j] == array.GetLength(1))
                    {
                        Console.WriteLine($"{number} = {0}");
                        number++;
                    }
                    else continue;
                else
                {
                    count++;
                }
            }
        }
        Console.WriteLine($"{number} встречается {count}");
        count = 0;
        number++;
        findCount(number);
    }
}