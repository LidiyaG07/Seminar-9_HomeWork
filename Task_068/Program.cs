/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.WriteLine("Введите число M и N: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());


static int Function(int n, int m)
{
    while (n != 0)
    {
        if (m == 0)
            m = 1;
        else
            m = Function(n, m - 1);
        n--;
    }
    return m + 1;
}

Console.WriteLine($"Функция Аккермана А({m},{n}) = " + Function(m, n));

