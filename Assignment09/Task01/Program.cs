/*  Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

    M = 1; N = 5 -> "2, 4"
    M = 4; N = 8 -> "4, 6, 8" */

Console.Clear();

int numberM = Prompt("Введите число М");
int numberN = Prompt("Введите число N");

if (numberM >= numberN)
{
    Console.WriteLine("Число М должно быть меньше числа N");
}
else
{
    Console.WriteLine($"Чётные натуральные числа в диапазоне {numberM} - {numberN}:");
    GetEvenNaturalNumbers(numberM, numberN);
}



int Prompt(string message)
{
    Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}


void GetEvenNaturalNumbers(int numberM, int numberN)
{
    if (numberM > numberN)
    {
        Console.WriteLine();
        Environment.Exit(0);
    }

    if (numberM % 2 != 0)
    {
        numberM++;
    }

    Console.Write($"{numberM} ");
    numberM += 2;

    GetEvenNaturalNumbers(numberM, numberN);
}