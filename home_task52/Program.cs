/*
Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] GetArray(int rows, int columns, int minRandomValue, int maxRandomValue)
{
    int[,] array = new int[rows, columns];
    var ran = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = ran.Next(minRandomValue, maxRandomValue + 1);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

string GetMidlleArithmeticInColums(int[,] array)
{
    string res = "Среднее арифметическое каждого столбца: ";
    double[] midlleArithm = new double[array.GetLength(1)];
    //сначала столбцы, потом строки!
    for (int i = 0; i < array.GetLength(1); i++)
    {
        midlleArithm[i] = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            midlleArithm[i] += array[j, i];
        }
        midlleArithm[i] /= array.GetLength(0);
        res += $"{midlleArithm[i]:f2}";
        if (i < array.GetLength(1) - 1)
            res += "; ";
        else
            res += ".";
    }
    return res;
}

int rows = 3;
int columns = 4;
int minValue = -10;
int maxValue = 10;
int[,] array = GetArray(rows, columns, minValue, maxValue);
Console.Write($"Двумерный целочисленный массив [{rows}*{columns}], ");
Console.WriteLine($"в диапазоне {minValue} до {maxValue}:");
ShowArray(array);

Console.WriteLine(GetMidlleArithmeticInColums(array));