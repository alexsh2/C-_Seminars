/*  Пользователь вводит с клавиатуры M чисел. 
    Посчитайте, сколько чисел больше 0 ввёл пользователь.
    0, 7, 8, -2, -2 -> 2
    1, -7, 567, 89, 223 -> 4 */

Console.Clear();

Console.WriteLine("Введите несколько чисел, разделяя их пробелом");
string[] input = GetInput();
int count = CountZeros(input);

if (count > 0)
{
    Console.WriteLine($"Пользователь ввёл {count} {ProperWord(count)} больше 0.");
}
else if (count == 0)
{
    Console.WriteLine("Пользователь не вводил чисел больше 0.");
}
else
{
    Console.WriteLine("Введено как минимум одно не числовое значение.");
}




string[] GetInput()
{
    string? input = Console.ReadLine();
    if (input is not null)
    {
        string[] splitLine = input.Split(" ");
        return splitLine;
    }
    else
    {
        string[] empty = new string[1];
        return empty;
    }

}


bool ConvertInputNumber(string item, out int number)
{
    if (int.TryParse(item, out number))
    {
        return true;
    }
    else
    {
        return false;
    }

}


int CountZeros(string[] input)
{
    int number = 0;
    int count = 0;
    foreach (var item in input)
    {
        if (ConvertInputNumber(item, out number))
        {
            if (number > 0)
            {
                count++;
            }
        }
        else
        {
            count = -1;
            break;
        }
    }
    return count;
}



string ProperWord(int count)
{
    string temp = string.Empty;
    if ((count == 1 || count % 10 == 1) && count != 11 && count % 100 != 11)
    {
        temp = "число";
    }
    else if ((count != 12 && (count == 2 || count % 10 == 2)) || (count != 13 && (count == 3 || count % 10 == 3)) || (count != 14 && (count == 4 || count % 10 == 4)))
    {
        temp = "числа";
    }
    else
    {
        temp = "чисел";
    }

    return temp;
}