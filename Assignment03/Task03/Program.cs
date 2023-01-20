/*  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    3 -> 1, 8, 27
    5 -> 1, 8, 27, 64, 125 */

    Console.Clear();


    string inpMessage = "Введите целое число: ";

    GetCubeTable(IntInput(inpMessage));

    // Ввод и конвертация числа
    int IntInput(string msg)
    {
        int num = 0;
        Console.Write(msg);
        num = Convert.ToInt32(Console.ReadLine());
        return num;
    }

    // Вычисление куба чисел в диапазоне от 1 до N и построение таблицы для вывода в консоль
    void GetCubeTable(int num)
    {
        Console.WriteLine("Число\tКуб числа");
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine("{0}\t{1}", i, Math.Pow(i,3));
        }
    }


