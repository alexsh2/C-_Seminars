/*  Задайте массив заполненный случайными положительными трёхзначными числами. 
    Напишите программу, которая покажет количество чётных чисел в массиве.
    [345, 897, 568, 234] -> 2 */

Console.Clear();

int[] intArray = CreateIntArray();
PrintArray(intArray);
Console.WriteLine($"Количество чётных чисел в массиве: {CountEvenNumbers(intArray)}");


// Создание массива случайных чисел
int[] CreateIntArray()
{
    Random rnd = new Random();
    int size = rnd.Next(7, 16);
    int min = rnd.Next(100, 102);
    int max = rnd.Next(800, 1000);

    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

// Вывод массива в консоль
void PrintArray(int[] array)
{
    Console.Write("Сгенерирован массив случайных чисел: ");

    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
        {
            Console.Write($"[{array[i]}, ");
        }
        else if (i == array.Length - 1)
        {
            Console.Write($"{array[i]}]");
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }

    Console.WriteLine();
}

// Подсчёт количества чётных чисел в массиве
int CountEvenNumbers(int[] array)
{
    int count = 0;

    foreach (var item in array)
    {
        if (item % 2 == 0)
        {
            count++;
        }
    }

    return count;
}