/*  Задайте двумерный массив из целых чисел. Найдите 
среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.   */

int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray2D(int[,] array2D)
{
    Random rnd = new Random();
    int minValue = InputNumberWithMessage("Введите минимальное число из диапазона случайных чисел ");
    int maxValue = InputNumberWithMessage("Введите максимальное число из диапазона случайных чисел ");
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
}

void PrintArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write(array2D[i, j] + " ");
        }

        System.Console.WriteLine();
    }
}




int rows = InputNumberWithMessage("Введите количество строк создаваемого массива ");
int columns = InputNumberWithMessage("Введите количество столбцов создаваемого массива ");

int[,] array2D = new int[rows, columns];

FillArray2D(array2D);
System.Console.WriteLine();
PrintArray2D(array2D);
System.Console.WriteLine();


for (int j = 0; j < array2D.GetLength(1); j++)
{
    double average = 0;

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        average = average + array2D[i, j];


    }
    average = Math.Round(average / array2D.GetLength(0), 2);
    System.Console.Write($"{average} ");
}

