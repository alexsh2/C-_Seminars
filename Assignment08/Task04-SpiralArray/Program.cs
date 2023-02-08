/*  Напишите программу, которая заполнит спирально квадратный массив.
    Например, на выходе получается вот такой массив:
    01 02 03 04
    12 13 14 05
    11 16 15 06
    10 09 08 07 */

Console.Clear();


int rows = 5;
int columns = 5;


PrintArray(CreateSpiralArray(rows, columns));
Console.WriteLine();


int[,] CreateSpiralArray(int n, int m)
{
    int[,] array = new int[n, m];
    int currentValue = 1;
    int x = 0, y = 0, size = array.GetLength(0);


      while (size > 0)
        {
            for (int i = y; i <= y + size - 1; i++)
            {
                array[x, i] = currentValue++;
            }

            for (int j = x + 1; j <= x + size - 1; j++)
            {
                array[j, y + size - 1] = currentValue++;
            }

            for (int i = y + size - 2; i >= y; i--)
            {
                array[x + size - 1, i] = currentValue++;
            }

            for (int i = x + size - 2; i >= x + 1; i--)
            {
                array[i, y] = currentValue++;
            }

            x = x + 1;
            y = y + 1;
            size = size - 2;
        }
        return array;
}



void PrintArray(int[,] array)
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