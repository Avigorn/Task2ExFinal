// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
int ReadInt(string message)
{
    System.Console.Write($"{message}: ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(0);
    return 0;
}

int GetAkkermanNum(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return GetAkkermanNum(M - 1, 1);
    }
    else
    {
        return (GetAkkermanNum(M - 1, GetAkkermanNum(M, N - 1)));
    }
}

int NumFirst = ReadInt("Введите первое число");
int NumLast = ReadInt("Введите второе число");
System.Console.WriteLine(GetAkkermanNum(NumFirst, NumLast));