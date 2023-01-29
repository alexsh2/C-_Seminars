/*  Задайте одномерный массив, заполненный случайными числами. 
    Найдите второе максимальное значение среди элементов массива.
    [3, 7, 23, 12] -> 12
    [-4, -6, 89, 6] -> 6
 */
using System.Diagnostics;

Console.Clear();

int[] intArray = CreateIntArray();
PrintArray(intArray);
Stopwatch stopwatch = new Stopwatch();

stopwatch.Start();
Console.WriteLine($"Второе максимальное значение среди элементов массива: {SecondMax(intArray)}");
stopwatch.Stop();
Console.WriteLine($"First run: {stopwatch.ElapsedTicks}");

stopwatch.Start();
Console.WriteLine($"Второе максимальное значение среди элементов массива: {SecondMaxSorted(intArray)}");
stopwatch.Stop();
Console.WriteLine($"Second run: {stopwatch.ElapsedTicks}");

// Создание массива случайных чисел
int[] CreateIntArray()
{
    Random rnd = new Random();
    int size = rnd.Next(6, 13);
    int min = rnd.Next(-100, -90);
    int max = rnd.Next(80, 100);
    //int max = rnd.Next(-10, -5);      // Для тестирования отрицательных значений

    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    // array[0] = 99;                   // Для...
    // array[1] = 99;                   // тестирования...
    // array[2] = 98;                   // первых...
    // array[array.Length - 1] = 99;
    // array[0] = -1;                   // позиций...
    // array[1] = -2;                   // с максимальными...
    // array[2] = -2;                   // значениями
    // array[array.Length - 1] = -1;

    // array[3] = 65;                   // Для...
    // array[4] = 65;                   // теситрования...
    // array[3] = -6;                   // дублирующих...
    // array[4] = -6;                   // значений


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


// Определение второго максимального значения среди элементов массива
int SecondMax(int[] array)
{
    int max = array[0];
    int max2 = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] == max)
        {
            continue;
        }
        else
        {
            max2 = array[i];
        }
    }


    foreach (var item in array)
    {
        if (item != max)
        {
            if (item > max2)
            {
                max2 = item;
            }
        }
    }

    return max2;
}


// Определение второй величины в массиве сортировкой значений

int SecondMaxSorted(int[] a)
{
    for (int j = 0; j < a.Length - 1; j++)
    {
        for (int i = 0; i < a.Length - j - 1; i++)
        {
            if (a[i] > a[i + 1])
            {
                int b = a[i];
                a[i] = a[i + 1];
                a[i + 1] = b;
            }
        }
    }
    // Console.WriteLine("Максимальный элемент= " + a[a.Length - 1]);
    // Console.WriteLine("Второй по величине= " + a[a.Length - 2]); => не учитывает возможное дублирование максимального значения
    
    return a[a.Length - 2];

}