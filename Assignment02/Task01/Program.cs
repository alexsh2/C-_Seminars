/*  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    456 -> 5
    782 -> 8
    918 -> 1 */

Console.Clear();

int rank = 3;
int number = -1;
int index = 2;
int digit = 0;

while (number == -1)
{
    StrInput("Введите трёхзначное число: ");
    number = IntInput(rank);
}

digit = SelectDigit(number, rank, index);
Console.WriteLine($"{index}-я цифра числа - {digit}");



void StrInput(string msg)   // Ввод сообщения
{
    Console.Write(msg);
}

int IntInput(int n = 0)     // Валидация разрядности введённого числа
{
    bool isNumber = false;
    int num = 0;
    string? inp = Console.ReadLine();

    if (isNumber = int.TryParse(inp, out num))
    {
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
                num = -1;
            }
        }
    }
    else
    {
        Console.WriteLine("Необходимо ввести число!");
        num = -1;
    }

    return num;
}

int SelectDigit(int num, int rank, int index)
{
    int[] digits = new int[rank];

    for (int i = 0; i < rank; i++)
    {
        digits[rank - 1 - i] = num % 10;
        num = num / 10;
    }

    return digits[index - 1];

}