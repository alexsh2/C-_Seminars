/*  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3М пространстве.
    A (3,6,8); B (2,1,-7), -> 15.84
    A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Clear();

string inputA = "Введите координаты точки А";
string inputB = "Введите координаты точки B";
int[] coordA = new int[3];
int[] coordB = new int[3];

IntInput(inputA, out coordA);
IntInput(inputB, out coordB);

double dist = CalcDistance(coordA, coordB);
Console.WriteLine($"Расстояние между точками А и B: {dist:F2}");


// Ввод и конвертация координат точки на 3М графике
void IntInput(string msg, out int[] coordinates)
{
    string[] letters = { "X", "Y", "Z" };
    coordinates = new int[3];

    for (int i = 0; i < 3; i++)
    {
        Console.Write($"{msg}: {letters[i]} = ");
        coordinates[i] = Convert.ToInt32(Console.ReadLine());
    }
}


// Вычисление расстояния между двумя точками на 3М графике
double CalcDistance(int[] coordA, int[] coordB)
{
    // Вычисляем разность координат по каждой оси
    int tempX = (coordB[0] - coordA[0]);
    int tempY = (coordB[1] - coordA[1]);
    int tempZ = (coordB[2] - coordA[2]);

    // Суммируем разности координат, возведённые в квадрат
    int temp = tempX * tempX + tempY * tempY + tempZ * tempZ;

    // Извлекаем квадратный корень из полученной суммы
    double dist = Math.Sqrt(temp);

    return dist;
}

