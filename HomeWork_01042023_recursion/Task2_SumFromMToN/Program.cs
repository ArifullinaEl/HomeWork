/* Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumFromMtoN(int m, int n)
{
    if (n == m) return m;
    else return n + SumFromMtoN(m, n - 1);
}

int m = InputNumberWithMessage("Введите M: ");
int n = InputNumberWithMessage("Введите N: ");


Console.WriteLine(SumFromMtoN(m, n));