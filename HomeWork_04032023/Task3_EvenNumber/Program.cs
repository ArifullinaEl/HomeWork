// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

int inputNumber = Convert.ToInt32(Console.ReadLine());
int even = inputNumber % 2;
if (even == 0)
{
    System.Console.WriteLine("это число четное");
}

else
{
    System.Console.WriteLine("это число нечетное");
}



