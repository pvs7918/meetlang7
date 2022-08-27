/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] GetArray(int rows, int columns, int minRandomValue, int maxRandomValue)
{
    double[,] array = new double[rows, columns];
    var ran = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = ran.NextDouble() * (maxRandomValue - minRandomValue) + minRandomValue;
        }
    }
    return array;
}

void ShowArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write ($"{array[i, j]:f2} ");
        }
        Console.WriteLine();
    }
}

int rows = 3;
int columns = 4;
int minValue = -10;
int maxValue = 10;
double[,] array = GetArray(rows, columns, minValue, maxValue);
Console.Write($"Двумерный массив размером [{rows}*{columns}], ");
Console.WriteLine($"заполненный случайными числами от {minValue} до {maxValue}:");
ShowArray(array);