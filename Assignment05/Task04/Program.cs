/*  Задайте одномерный массив, заполненный случайными числами. 
    Найдите второе максимальное значение среди элементов массива.
    [3, 7, 23, 12] -> 12
    [-4, -6, 89, 6] -> 6
 */

Console.Clear();

int[] intArray = CreateIntArray();
PrintArray(intArray);
Console.WriteLine($"Максимальное значение среди элементов массива: {SecondMax(intArray).Item1}");
Console.WriteLine($"Второе максимальное значение среди элементов массива: {SecondMax(intArray).Item2}");


// Создание массива случайных чисел
int[] CreateIntArray()
{
    Random rnd = new Random();
    int size = rnd.Next(6, 13);
    int min = rnd.Next(-100, -90);
    int max = rnd.Next(80, 100);

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


// Определение второго максимального значения среди элементов массива
(int, int) SecondMax(int[] array)
{
    int max = array[0];
    int max2 = array[0];


    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == max)
        {
            continue;
        }
        else if (array[i] > max)
        {
            max2 = max;
            max = array[i];
        }
        else if (array[i] > max2)
        {
            max2 = array[i];
        }
        else if (max2 == max)
        {
            max2 = array[i];
        }
    }

    return (max, max2);
}