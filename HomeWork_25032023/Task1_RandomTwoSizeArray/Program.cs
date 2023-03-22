/*  Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9    */


int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void FillArray2D(double[,] array2D)
{
    Random rnd = new Random();
    int minValue = InputNumberWithMessage("Введите минимальное число из диапазона случайных чисел ");
    int maxValue = InputNumberWithMessage("Введите максимальное число из диапазона случайных чисел ");
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = Math.Round(rnd.NextDouble() * (maxValue - minValue) + minValue, 2);
        }
    }
}

void PrintArray2D(double[,] array2D)
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

double[,] array2D = new double[rows, columns];

FillArray2D(array2D);
System.Console.WriteLine();
PrintArray2D(array2D);
