﻿// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



Console.Write("Введите целое положительное число ");
int inputNumber = Convert.ToInt32(Console.ReadLine ());

if (inputNumber < 0)
{
    System.Console.Write("Вы ошиблись");
}

else
{
    for (int i = 1; i <= inputNumber; i++)
    {
        int result = (int) Math.Pow(i ,3);
        System.Console.Write(result + " ");
    }
}

