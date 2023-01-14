/*  Напишите программу, которая принимает на вход три числа и 
    выдаёт максимальное из этих чисел.
    2, 3, 7 -> 7
    44 5 78 -> 78
    22 3 9 -> 22 */

string inpValue;
int[] numbers = new int[3];
string[] seq = new string[] { "первое", "второе", "третье" };

for (int i = 0; i < 3; i++)
{
    Console.Write($"Введите {seq[i]} целое число: ");

    inpValue = Console.ReadLine();
    numbers[i] = Convert.ToInt32(inpValue);
}
Console.WriteLine($"Максимальное число из введённых: {numbers.Max()}");
