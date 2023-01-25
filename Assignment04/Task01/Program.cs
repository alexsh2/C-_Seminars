/*  Напишите цикл, который принимает на вход два числа (A и B) и 
    возводит число A в натуральную степень B. Не использовать Math.Pow
    3, 5 -> 243 (3⁵)
    2, 4 -> 16 */

Console.Clear();

string inpMessage = "Введите целое число";
long[] numbers = new long[2];
long result = 0;

if (LongInput(inpMessage, out numbers))
{
    result = Exponantiation(numbers);
    Console.WriteLine($"{numbers[0]} в степени {numbers[1]} = {result}");
}


// Ввод и конвертация числа
bool LongInput(string msg, out long[] nums)
{
    string[] letters = { "A", "B" };
    nums = new long[2];

    for (int i = 0; i < 2; i++)
    {
        long value;
        Console.Write($"{msg}: {letters[i]} = ");
        if (long.TryParse(Console.ReadLine(), out value) && value > 0)   // Введено натуральное число?
        {
            nums[i] = value;
        }
        else
        {
            Console.WriteLine("Введённое число не является натуральным.");
            return false;
        }
    }
    return true;
}


// Возведение в степень
long Exponantiation(long[] nums)
{
    long result = nums[0];
    long count = nums[1] - 1;

    while (count > 0)
    {
        result *= nums[0];
        count--;
    }

    return result;
}