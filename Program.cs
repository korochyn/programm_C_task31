// Задача 68. Напишите программу вычисления функции Аккермана с помошью рекурсии. Даны два неотрицательных числа m и n.
// m=2, n=3 -> A(m,n)=9
// m=3, n=2 -> A(m,n)=29

// ввод числа 
int Promt (string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine()!;
    int result = int.Parse (ReadInput);
    return result;
}

// вывод чисел с рекурсией
int Akkerman(int m, int n)
{
    if (m == 0) return n+1;
    if (n == 0) return Akkerman(m-1, 1);
    else return Akkerman(m-1, Akkerman(m,n-1));
}




int m = Promt("Введите число M  :");
int n = Promt("Введите число N  :");
Console.WriteLine(Akkerman(m,n));

