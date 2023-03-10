/* Напишите программу, которая принимает на вход число и выдаёт
сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int SummDigits(int A)
{
    int s = 0;
    while (A != 0)
    {
    s = s + A % 10;
    A = A / 10;
    }
    return s;
}

int a = InputNumberWithMessage("Введите число : ");
int result = SummDigits(a);


/*int s = 0;
while (a != 0)
{
    s = s + a % 10;
    a = a / 10;
    System.Console.WriteLine(s);
}*/

System.Console.WriteLine($"Сумма всех цифр в числе {a} = {result}");