/*  Задайте одномерный массив, заполненный случайными числами. 
    Найдите второе максимальное значение среди элементов массива.
    [3, 7, 23, 12] -> 12
    [-4, -6, 89, 6] -> 6
 */

Console.Clear();

int[] intArray = CreateIntArray();
PrintArray(intArray);

Console.WriteLine();
Console.WriteLine($"Максимальное значение среди элементов массива: {SecondMax(intArray).Item1}");
Console.WriteLine($"Второе максимальное значение среди элементов массива: {SecondMax(intArray).Item2}");
Console.WriteLine();


// Создание массива случайных чисел
int[] CreateIntArray()
{
    Random rnd = new Random();
    int size = rnd.Next(6, 13);
    int min = rnd.Next(-100, -90);
    //int max = rnd.Next(80, 100);
    int max = rnd.Next(-10, -5);      // Для тестирования отрицательных значений

    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    // array[0] = 99;                   // Тестовые данные...
    // array[1] = 99;            
    // array[2] = 98;          
    // array[array.Length - 1] = 99;
    // array[3] = 65;           
    // array[4] = 65;                  

    // array[0] = -1;                 
    // array[1] = -1;                   
    // array[2] = -2;                   
    // array[array.Length - 1] = -1;
    // array[3] = -6;                   
    // array[4] = -6;                  

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