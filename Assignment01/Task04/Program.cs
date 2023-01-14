/*  Напишите программу, которая на вход принимает число (N), 
    а на выходе показывает все чётные числа от 1 до N.
    5 -> 2, 4
    8 -> 2, 4, 6, 8 */

string inpValue;
int value, temp;
int evenNumbers = 0;
List<int> result = new List<int>();

Console.Write($"Введите целое число: ");
inpValue = Console.ReadLine();
value = Convert.ToInt32(inpValue);
temp = value;


if (temp % 2 != 0)
{
    if (temp > 0)
    {
        temp--;
    }
    else
    {
        temp++;
    }

}

for (int i = 0; i < Math.Abs(temp) / 2; i++)
{
    if (temp > 0)
    {
        result.Add(evenNumbers += 2);
    }
    else
    {
        result.Add(evenNumbers -= 2);
    }
}

Console.WriteLine($"Чётные числа в диапазоне от 0 до {value}: ");

foreach (int i in result)
{
    Console.WriteLine(i);
}
