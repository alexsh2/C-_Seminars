/*  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    [3, 7.4, 22.3, 2, 78] -> 76
 */

Console.Clear();

double[] doubleArray = CreateIntArray();
PrintArray(doubleArray);
Console.WriteLine($"Разница между максисмальным и минимальным значениями в массиве: {MinMaxDifference(doubleArray):F2}");


// Создание массива случайных чисел
double[] CreateIntArray()
{
    Random rnd = new Random();
    int size = rnd.Next(5, 10);
    double[] array = new double[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * 10.73;
    }

    return array;
}


// Вывод массива в консоль
void PrintArray(double[] array)
{
    Console.Write("Сгенерирован массив случайных чисел: ");

    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
        {
            Console.Write($"[{array[i]:F2}, ");
        }
        else if (i == array.Length - 1)
        {
            Console.Write($"{array[i]:F2}]");
        }
        else
        {
            Console.Write($"{array[i]:F2}, ");
        }
    }

    Console.WriteLine();
}


// Вычисление разницы между максимальным и минимальным значениями элементов массива
double MinMaxDifference(double[] array)
{
    double result = 0;
    double min = array[0];
    double max = array[0];

    foreach (var item in array)
    {
        if (item < min)
        {
            min = item;
        }
        else if (item > max)
        {
            max = item;
        }
    }

    return result = max - min;
}
