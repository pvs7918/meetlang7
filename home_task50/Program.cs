/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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

void SearchElement(int[,] array, int searchRow, int searchColumn)
{
    if (searchRow > array.GetLength(0) - 1)
    {
        Console.WriteLine("такого числа в массиве нет!");
    }
    else
    {
        if (searchColumn > array.GetLength(1) - 1)
        {
            Console.WriteLine("такого числа в массиве нет!");
        }
        else
        {
            Console.Write($"значение искомого элемента [{searchRow},{searchColumn}]");
            Console.WriteLine($" = {array[searchRow, searchColumn]}");
        }
    }
}

int rows = 3;
int columns = 4;
int minValue = -10;
int maxValue = 10;
int[,] array = GetArray(rows, columns, minValue, maxValue);
Console.Write($"Двумерный массив размером [{rows}*{columns}], ");
Console.WriteLine($"заполненный случайными числами от {minValue} до {maxValue}:");
ShowArray(array);

Console.Write("Введите ряд: ");
int searchRow = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите колонку: ");
int searchColumn = Convert.ToInt32(Console.ReadLine()) - 1;

SearchElement(array, searchRow, searchColumn);