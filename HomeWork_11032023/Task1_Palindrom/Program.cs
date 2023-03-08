/* Напишите программу, которая принимает на вход пятизначное 
число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */



string Prompt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    return value;
}

string inputNumber = Prompt ("Введите пятизначное число: ");
int l = inputNumber.Length;

if (l == 5)
{
    if (inputNumber[0] == inputNumber[4] && inputNumber [1] == inputNumber[3])
    {
        Console.WriteLine(inputNumber + " Палиндром");
    }

    else
    {
        Console.WriteLine(inputNumber + " Не палиндром");
    }
}
else
{
    Console.WriteLine ("Вы ввели НЕ 5-и значное число");
}