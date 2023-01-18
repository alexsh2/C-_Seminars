/*  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    456 -> 5
    782 -> 8
    918 -> 1 */

Console.Clear();

int rank = 3;               // Разрядность вводимого числа
int number = -1;            // Вводимое число
int sequenceNumber = 2;     // Порядковый номер искомой цифры
int digit = 0;              // Искомая цифра
bool flag = false;          // Индикатор результата проверки введённого значения

while (flag == false)
{
    Console.Write("Введите трёхзначное число: ");
    number = IntInput(out flag, rank);
}

digit = SelectDigit(number, rank, sequenceNumber);
Console.WriteLine($"{sequenceNumber}-я цифра числа: {digit}");


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
int SelectDigit(int num, int rank, int seq)
{
    int[] digits = new int[rank];
    int offset = rank - 1;

    for (int i = 0; i < rank; i++)
    {
        digits[offset - i] = num % 10;
        num = num / 10;
    }

    return digits[seq - 1];

}