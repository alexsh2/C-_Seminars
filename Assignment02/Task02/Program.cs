/*  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    645 -> 5
    78 -> третьей цифры нет
    32679 -> 6 */

Console.Clear();

int number = 0;             // Вводимое число
int count = 0;              // Количество цифр во введённом числе
int sequenceNumber = 3;     // Порядковый номер искомой цифры
int digit = 0;              // Искомая цифра
bool flag = false;          // Индикатор результата проверки введённого значения

while (flag == false)
{
    Console.Write("Введите целое число: ");
    number = IntInput(out flag);
}

count = number.ToString().Length;

if (sequenceNumber > count)
{
    Console.WriteLine($"{sequenceNumber}-й цифры во введённом числе нет");
}
else
{
    digit = SelectDigit(number, sequenceNumber, count);
    Console.WriteLine($"{sequenceNumber}-я цифра числа: {digit}");
}


// Валидация разрядности введённого числа
int IntInput(out bool flag, int n = 0)
{
    flag = true;
    bool isNumber = false;
    int num = 0;
    string? inp = Console.ReadLine();

    if (isNumber = int.TryParse(inp, out num))
    {
        num = Math.Abs(num);
        int temp = num;
        int count = 0;

        if (n != 0)
        {
            while (temp > 0)
            {
                temp = temp / 10;
                count++;
            }

            if (count > n || count < n)
            {
                Console.WriteLine($"Разрядность введённого числа {num} отличается от запрашиваемой.");
                flag = false;
            }
        }
    }
    else
    {
        Console.WriteLine("Необходимо ввести число!");
        flag = false;
    }

    return num;
}

// Поиск запрашиваемой цифры
int SelectDigit(int num, int seq, int cnt)
{
    int[] digits = new int[cnt];
    int offset = cnt - 1;

    for (int i = 0; i < cnt; i++)
    {
        digits[offset - i] = num % 10;
        num = num / 10;
    }

    return digits[seq - 1];
}

