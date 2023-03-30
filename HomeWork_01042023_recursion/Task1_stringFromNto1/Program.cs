/* Задайте значение N. Напишите программу, которая выведет +
все натуральные числа в промежутке от N до 1. Выполнить с 
помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */


int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int RecursionFunctionFromNtoOne(int n, int m)
{
    if (n == m) return n;
    else Console.Write($"{RecursionFunctionFromNtoOne(n, m + 1)}, ");
    return m;
}

int n = InputNumberWithMessage("Введите N: ");
if (n < 1)
{
    Console.WriteLine("Ошибка! Введите положительное число!");
    return;
}
Console.WriteLine(RecursionFunctionFromNtoOne(n, 1));


