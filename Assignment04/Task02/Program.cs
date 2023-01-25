/*  Напишите программу, которая принимает на вход число и 
    выдаёт сумму цифр в числе.
    452 -> 11
    82 -> 10
    9012 -> 12 */

Console.Clear();

string inpMessage = "Введите целое число";
long number = 0;

if (LongInput(inpMessage, out number))
{
    Console.WriteLine($"Сумма цифр введёного числа равна {DigitsSum(number, CountDigits(number))}");
}



// Ввод и конвертация числа
bool LongInput(string msg, out long num)
{

    Console.Write($"{msg}: ");
    if (!(long.TryParse(Console.ReadLine(), out num) && num != 0))   // Введено целое число?
    {
        Console.WriteLine("Необходимо ввести целое число!");
        return false;
    }
    return true;
}

// Определение количества цифр в числе
long CountDigits(long num)
{
    long count = 0;
    long temp = Math.Abs(num);

    while (temp > 0)
    {
        temp /= 10;
        count++;
    }

    return count;
}

// Определение суммы цифр
long DigitsSum(long num, long size)
{
    long sum = 0;
    long temp = Math.Abs(num);

    for (int i = 0; i < size; i++)
    {
        sum += temp % 10;
        temp /= 10;
    }

    return sum;
}