/*  Напишите программу, которая на вход принимает число и 
    выдаёт, является ли число чётным (делится ли оно на два без остатка).
    4 -> да
    -3 -> нет
    7 -> нет */

string inpValue;
int value;

Console.Write($"Введите целое число: ");
inpValue = Console.ReadLine();
value = Convert.ToInt32(inpValue);

if (value % 2 == 0)
{
    Console.WriteLine($"Введено чётное число");
}
else
{
    Console.WriteLine($"Введено нечётное число");
}
