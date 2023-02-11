/*  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30 */

Console.Clear();

int numberM = Prompt("Введите число М");
int numberN = Prompt("Введите число N");

if (numberM >= numberN)
{
    Console.WriteLine("Число М должно быть меньше числа N");
}
else
{
    Console.Write($"Сумма натуральных чисел в диапазоне {numberM} - {numberN}: {NaturalNumbersSum(numberM, numberN)}");
    Console.WriteLine();
}



int Prompt(string message)
{
    Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}


int NaturalNumbersSum(int numberM, int numberN)
{
    if(numberM > numberN)
    {
        return 0;
    }

    return numberM + NaturalNumbersSum(numberM + 1, numberN);
}
