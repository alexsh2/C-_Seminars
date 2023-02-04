/*  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    m = 3, n = 4.
    0,5 7 -2 -0,2
    1 -3,3 8 -9,9
    8 7,8 -7,1 9 */

Console.Clear();

Print2DArray(Create2DArray(), "Сгенерирован двумерный массив случайных вещественных чисел: ");

double[,] Create2DArray(int rows = 3, int columns = 4)
{
    Random rndDouble = new Random();
    Random rndInt = new Random();
    double[,] array = new double[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rndDouble.NextDouble() * rndInt.Next(1, 11);
        }
    }

    return array;
}

void Print2DArray(double[,] array, string msg)
{
    Console.WriteLine(msg);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:F2}\t");
        }
    }
    Console.WriteLine();
}