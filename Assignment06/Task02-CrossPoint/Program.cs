/*  Напишите программу, которая найдёт точку пересечения двух прямых, 
    заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
    значения b1, k1, b2 и k2 задаются пользователем.
    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Clear();


string input1 = "Введите значения для первого уравнения";
string input2 = "Введите значения для второго уравнения";

double[] values1 = new double[2];
double[] values2 = new double[2];

IntInput(input1, 1, out values1);
IntInput(input2, 2, out values2);

if (values1[1] == values2[1])
{
    Console.WriteLine("k1 = k2 -> прямые не пересекаются");
}
else
{
    (double x, double y) = CrossPoint(values1[0], values1[1], values2[0], values2[1]);
    Console.WriteLine();
    Console.WriteLine($"Координаты точки пересечения прямых: x = {x}, y = {y}");
    Console.WriteLine();
}



// Ввод и конвертация координат точки на 3М графике
void IntInput(string msg, int n, out double[] values)
{
    string[] letters = { "b", "k" };
    values = new double[letters.Length];


    for (int i = 0; i < letters.Length; i++)
    {
        Console.Write($"{msg}: {letters[i]}{n} = ");
        values[i] = Convert.ToInt32(Console.ReadLine());
    }
}


// Вычисление x и y
(double, double) CrossPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    return (x, y);
}