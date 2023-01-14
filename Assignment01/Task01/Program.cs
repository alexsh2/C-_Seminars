/*  Напишите программу, которая на вход принимает два числа и 
    выдаёт, какое число большее, а какое меньшее.
    a = 5; b = 7 -> max = 7
    a = 2 b = 10 -> max = 10
    a = -9 b = -3 -> max = -3 */

string inpValue;
int[] numbers = new int[2];
string[] seq = new string[] { "первое", "второе" };

for (int i = 0; i < 2; i++)
{
    Console.Write($"Введите {seq[i]} целое число: ");

    inpValue = Console.ReadLine();
    numbers[i] = Convert.ToInt32(inpValue);
}
Console.WriteLine($"Максимальное число из введённых: {numbers.Max()}");

