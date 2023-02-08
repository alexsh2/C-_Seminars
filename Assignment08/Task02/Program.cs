/*  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7

    Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.Clear();

const int rows = 6;
const int columns = 6;

int[,] twoDArray = Create2DArray(rows, columns);

Print2DArray(twoDArray);
Console.WriteLine();
int[] rowsSum = RowValuesSum(twoDArray);
Console.WriteLine($"Строка {GetSmallerSum(rowsSum).Item2} содержит наименьшую сумму {GetSmallerSum(rowsSum).Item1}");



int[,] Create2DArray(int rows = 4, int columns = 4)
{
    Random rnd = new Random();
    int[,] twoDArray = new int[rows, columns];

    for (int i = 0; i < twoDArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoDArray.GetLength(1); j++)
        {
            twoDArray[i, j] = rnd.Next(0, 11);
        }
    }
    return twoDArray;
}


void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}


int[] RowValuesSum(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp += array[i, j];
        }
        sum[i] = temp;
    }
    return sum;
}


(int, int) GetSmallerSum(int[] array)
{
    int result = array[0];
    int index = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < result)
        {
            result = array[i];
            index = i;
        }
    }
    return (result, index + 1);
}
