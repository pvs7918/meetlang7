/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
и замените эти элементы на их квадраты.
Например, изначально массив  выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Задача 51: Задайте двумерный массив, заполните его случайными числами.
Найдите сумму элементов на главной диагонали (главная диагональ – это те элементы,
которые имеют индекс (0, 0), (1, 1)…).
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
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

int[,] ReplaceValuesInNechetIndexes(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 1 && j % 2 == 1)
            {
                array[i, j] = array[i, j] * array[i, j];
            }
        }
    }
    return array;
}

int FindSummMainDiagElements(int[,] array)
{
    int sum = 0;
    int minLen;
    if (array.GetLength(0) > array.GetLength(1))
        minLen = array.GetLength(1);
    else
        minLen = array.GetLength(0);

    for (int i = 0; i < minLen; i++)
    {
        sum += array[i, i];
    }
    return sum;
}

string GetStringFromArray(int[,] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j] + " ";
        }
        result += "\n";
    }
    return result;
}

int[,] array = GetArray(4, 4, 1, 10);
Console.WriteLine("Исходный массив:");
Console.WriteLine(GetStringFromArray(array));

array=ReplaceValuesInNechetIndexes(array);
Console.WriteLine("Результат по задаче 49 (исходный массив для следующей задачи):");
Console.WriteLine(GetStringFromArray(array));

Console.WriteLine("Результат по задаче 51:");
Console.WriteLine(FindSummMainDiagElements(array));