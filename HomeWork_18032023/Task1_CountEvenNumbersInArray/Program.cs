/* Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая 
покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void FillArrayRandom(int[] array)
{
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100,1000);
    }
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
            int even = array[i] % 2;
            if (even == 0)
            count = count + 1;
        
    }
    return count;
}

int length = InputNumberWithMessage("Введите размер массива: ");
int [] nunbers = new int [length];
FillArrayRandom(nunbers);
PrintArray(nunbers);
int result = CountEvenNumbers(nunbers);
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных чисел в массиве: {result}");




