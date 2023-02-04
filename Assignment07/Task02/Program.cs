/*  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
    и возвращает значение этого элемента или же указание, что такого элемента нет.

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    1,7 -> такого числа в массиве нет */

Console.Clear();

int[,] TwoDArray = Create2DArray();
Print2DArray(TwoDArray, "Сгенерирован двумерный массив случайных чисел");
Console.WriteLine();

int row = InputItemPosition("Введите номер строки");
int column = InputItemPosition("Введите номер колонки");
(bool yes, int item) = GetItem(TwoDArray, row, column);

if (yes)
{
    Console.WriteLine($"Значение элемента на позиции {row},{column}: {item}");
}
else
{
    Console.WriteLine($"В массиве отсутствует позиция {row},{column}");
}



int[,] Create2DArray(int rows = 5, int columns = 8)
{
    Random rnd = new Random();
    int[,] array = new int[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 21);
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


int InputItemPosition(string msg)
{
    Console.Write($"{msg}: ");
    return Convert.ToInt32(Console.ReadLine());
}


(bool, int) GetItem(int[,] array, int row, int column)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == row && j == column)
            {
                int number = array[i - 1, j - 1];
                return (true, number);
            }
        }
    }
    return (false, -1);
}