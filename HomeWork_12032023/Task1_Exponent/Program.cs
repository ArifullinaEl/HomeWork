/* Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/


int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int CountExponent(int A, int E)
{
    int result = 1;

    for (int i=1; i <= E; i++)
    {
        result = result*A;
    }
    return result;
}

int a = InputNumberWithMessage("Введите число A: ");
int e = InputNumberWithMessage("Введите степень числа A: ");
int ce = CountExponent(a, e);

/*int result = 1;

for (int i=1; i <= e; i++)
{
    result = result*a;
}*/

System.Console.WriteLine($"{a} в степени {e}  = {ce}");