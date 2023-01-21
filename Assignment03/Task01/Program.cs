/*  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    14212 -> нет
    12821 -> да
    23432 -> да */

Console.Clear();

string inpMessage = "Введите целое число";
long inpLength = 0;

if (IsNumPalindrome(longInput(inpMessage, out inpLength), inpLength))
{
    Console.WriteLine("Введённое число является палиндромом");
}
else
{
    Console.WriteLine("Введённое число не является палиндромом");
}


// Ввод и конвертация числа
long longInput(string msg, out long len)
{
    Console.Write($"{msg}: ");
    string? inp = Console.ReadLine();
    len = inp.Length;
    long num = Convert.ToInt64(inp);
    return num;
}


// Проверка введённого числа на палиндромность
bool IsNumPalindrome(long num, long len)
{
    if (num != 0)
    {
        long temp = num;
        long count = 0;

        while (temp > 0)        // Определяем количество цифр в числе
        {
            temp = temp / 10;
            count++;
        }

        temp = num;
        long ind = len - count;
        long rightDigit = temp % 10;
        long leftDigit = num / Convert.ToInt64(Math.Pow(10, --count));
        long c = count / 2;

        while (c >= 1)          // Сравниваем цифры на "зеркальных" позициях
        {
            if (leftDigit == rightDigit)
            {
                temp = temp / 10;
                rightDigit = temp % 10;
                long temp1 = num / Convert.ToInt64(Math.Pow(10, --count));
                leftDigit = temp1 % 10;
                c--;
            }
            else
            {
                if (ind > 0)        // Проверка разницы между len и count: если она есть, значит потерян(ы) лидирующий(ие) 0
                {
                    temp = temp / 10;
                    rightDigit = temp % 10;
                    ind--;
                    continue;
                }

                return false;
            }
        }
        return true;
    }
    return false;
}