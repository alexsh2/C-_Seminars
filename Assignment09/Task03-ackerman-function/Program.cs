/*  Напишите программу вычисления функции Аккермана с помощью рекурсии. 
    Даны два неотрицательных числа m и n.
    m = 2, n = 3 -> A(m,n) = 9
    m = 3, n = 2 -> A(m,n) = 29 */

Console.Clear();

int numberM = Prompt("Введите неотрицательное целое число М");
int numberN = Prompt("Введите неотрицательное целое число N");

Console.WriteLine($"Значение функции Аккермана для чисел {numberM} и {numberN}: {AckermanFunction(numberM, numberN)}");



int Prompt(string message)
{
    Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}


int AckermanFunction(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }

    if(numberM != 0 && numberN == 0)
    {
        return AckermanFunction(numberM - 1, 1);
    }
    else
    {
        return AckermanFunction(numberM - 1, AckermanFunction(numberM, numberN - 1));
    }
}
