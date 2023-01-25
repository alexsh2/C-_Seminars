/*  Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
    Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах).  
    Реализовать через функции. 
    (* Доп сложность, “введите количество элементов массива”, 
    “Введите минимальный порог случайных значений”, 
    “Введите максимальный порог случайных значений”) */

Console.Clear();

string[] inpMessages = new string[]
{
    "Введите количество элементов массива",
    "Введите минимальный порог случайных значений",
    "Введите максимальный порог случайных значений"
};

long value = 0;
long[] values = new long[inpMessages.Length];

for (int i = 0; i < inpMessages.Length; i++)
{
    if (LongInput(inpMessages[i], out value))
    {
        values[i] = value;
    }
    else
    {
        break;
    }
}


if (value > 0)                      // Введеные числа провалидированы
{
    if (values[2] > values[1])      // && минимальный порог не больше максимального
    {
        long[] randomNumbers = RandNumbers(values);

        string[] result = Array.ConvertAll(randomNumbers, x => x.ToString());
        Console.WriteLine();
        Console.WriteLine($"Сгенерирован массив случайных чисел:");
        Console.WriteLine(string.Join(" ", result));

    }
    else
    {
        Console.WriteLine($"Непорядок!!! Минимальный порог случайных значений ({values[1]}) больше максимального порога ({values[2]}).");
    }
}



// Ввод числовых параметров
bool LongInput(string msg, out long num)
{
    Console.Write($"{msg}: ");
    if (!(long.TryParse(Console.ReadLine(), out num) && num > 0))

    {
        Console.WriteLine("Необходимо ввести целое положительное число!");
        return false;
    }

    return true;
}


// Создание массива
long[] RandNumbers(long[] values)
{
    long rank = values[0];
    long min = values[1];
    long max = values[2];
    long[] array = new long[rank];
    Random random = new Random();

    for (int i = 0; i < rank; i++)
    {
        array[i] = random.NextInt64(min, max);
    }

    return array;

}
