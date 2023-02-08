/*  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
    Например, даны 2 матрицы:
    2 4 | 3 4
    3 2 | 3 3
    Результирующая матрица будет:
    18 20
    15 18 */

Console.Clear();

int[,] arrayA = Create2DArray(2, 4, 3, 2);
Console.WriteLine("Матрица A:");
Print2DArray(arrayA);
Console.WriteLine();

int[,] arrayB = Create2DArray(3, 4, 3, 3);
Console.WriteLine("Матрица B:");
Print2DArray(arrayB);
Console.WriteLine();

int[,] arrayC = ArrayXArray(arrayA, arrayB);
Console.WriteLine("Произведение матриц A и B:");
Print2DArray(arrayC);




int[,] Create2DArray(int item1, int item2, int item3, int item4, int rows = 2, int columns = 2)
{
    int[,] array = new int[rows, columns];

    array[0, 0] = item1;
    array[0, 1] = item2;
    array[1, 0] = item3;
    array[1, 1] = item4;

    return array;
}


void Print2DArray(int[,] array)
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


int[,] ArrayXArray(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayA.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayB.GetLength(0); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return arrayC;
}