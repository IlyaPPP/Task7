/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07    */


int[,] array = new int[4, 4];   // двухмерный массив
int num = 1;                    // счетчик чисел
int numMax = (array.GetLength(0) * array.GetLength(1));         // максимальное число

int s = 0;                                  // счетчик по горизонтали
int a = array.GetLength(0) - 1;             // счетчик по вертикали

GorizontalToRight();
void GorizontalToRight()                        // функция заполнения числами слева направо
{
    if (num > numMax) return;
    else
    {
        for (int i = 0 + s; i < array.GetLength(0) - s; i++)
        {
            if (i == array.GetLength(0) - 1)
            {
                array[s, i] = num++;
                VerticalDown();                 // рекурсия на следующую функцию
            }
            else array[s, i] = num++;
        }
    }
}

void VerticalDown()                     // функция заполнения числами сверху вниз
{
    if (num > numMax) return;
    else
    {
        for (int j = 1; j < array.GetLength(1) - s; j++)
        {
            if (j == array.GetLength(1) - 1 - s)
            {
                array[j, a] = num++;
                j = 1 + s;
                GorizontalToLeft();         // рекурсия на следющую функцию
            }
            else array[j, a] = num++;
        }
    }
}

void GorizontalToLeft()                     // функиця заполнения числами справа налево
{
    if (num > numMax) return;
    else
    {
        for (int m = array.GetLength(0) - 2 - s; m - s >= 0; m--)
        {
            if (m - s == 0)
            {
                array[a, m] = num++;
                a--;
                VerticalUp();               // рекурсия на следующую функцию
            }
            else array[a, m] = num++;
        }
    }
}

void VerticalUp()                           // функиця заполнения числами снизу вверх
{
    if (num > numMax) return;
    else
    {
        for (int n = array.GetLength(1) - 2 - s; n > 0; n--)
        {
            if (n == 1)
            {
                array[n, s] = num++;
                s++;
                GorizontalToRight();            // рекурсия на первую функцию
            }
            else array[n, s] = num++;
        }
    }
}

Console.WriteLine($"0{array[0, 0]}, 0{array[0, 1]}, 0{array[0, 2]}, 0{array[0, 3]}");
Console.WriteLine($"{array[1, 0]}, {array[1, 1]}, {array[1, 2]}, 0{array[1, 3]}");
Console.WriteLine($"{array[2, 0]}, {array[2, 1]}, {array[2, 2]}, 0{array[2, 3]}");
Console.WriteLine($"{array[3, 0]}, 0{array[3, 1]}, 0{array[3, 2]}, 0{array[3, 3]}");
