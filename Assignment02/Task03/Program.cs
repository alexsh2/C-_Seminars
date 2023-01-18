/*  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
    6 -> да
    7 -> да
    1 -> нет */

Console.Clear();

int rank = 1;               // Разрядность вводимого числа
int number = 0;             // Вводимое число
bool flag = false;          // Индикатор результата проверки введённого значения

while (flag == false)
{
    Console.Write("Введите число от 1 до 9: ");
    number = IntInput(out flag, rank);
}

WeekDays(number);


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

        if (num == 0)
        {
            flag = false;
        }
        else if (n != 0)
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

// Проверка соответствия дням недели
void WeekDays(int num)
{
    if (num >= 1 && num <= 5)
    {
        Console.WriteLine($"Введённое число {num} не соответствует выходному дню.");
    }
    else if (num == 6)
    {
        
        Console.WriteLine($"Введённое число {num} соответствует субботе.");
    }
    else if (num == 7)
    {
        Console.WriteLine($"Введённое число {num} соответствует воскресению.");
    }
    else
    {
        Console.WriteLine($"Введённое число {num} не соответствует дню недели.");
        flag = false;
    }
}