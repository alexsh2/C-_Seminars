/*  Задайте одномерный массив, заполненный случайными числами. 
    Найдите сумму элементов, стоящих на нечётных позициях.
    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0
 */

Console.Clear();

int[] intArray = CreateIntArray();
PrintArray(intArray);
Console.WriteLine($"Сумма элементов, расположенных на нечётных позициях (index = 0, index = 2,...): {OddNumbersSum(intArray)}");


// Создание массива случайных чисел
int[] CreateIntArray()
{
    Random rnd = new Random();
    int size = rnd.Next(7, 16);
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


// Подсчёт суммы элементов, расположенных на нечётных позициях (index = 0, 2, 4,...)
int OddNumbersSum(int[] array)
{
    int result = 0;

    for (int i = 0; i < array.Length; i+=2)
    {
        result += array[i];
    }

    return result;
}