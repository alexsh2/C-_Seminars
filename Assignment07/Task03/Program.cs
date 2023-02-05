/*  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Clear();


int[,] twoDArray = Create2DArray();
Print2DArray(twoDArray, "Сгенерирован двумерный массив случайных чисел");
Console.WriteLine();

double[] columnAverages = CalculateColumnAverage(twoDArray);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
for (int i = 0; i < columnAverages.Length; i++)
{
    Console.Write($"{columnAverages[i]:F2}\t");
}
Console.WriteLine();



int[,] Create2DArray(int rows = 5, int columns = 8)
{
    Random rnd = new Random();
    int[,] array = new int[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 11);
        }
    }
    return array;
}


void Print2DArray(int[,] array, string msg)
{
    Console.WriteLine($"{msg}:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
    }
    Console.WriteLine();
}


double[] CalculateColumnAverage(int [,] array)
{
    double[] averages = new double[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            averages[i] += array[j,i];
        }
        averages[i] /= array.GetLength(0);
    }

    return averages;
}