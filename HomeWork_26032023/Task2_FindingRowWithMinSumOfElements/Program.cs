/* Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка */


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
            if (array2D[i, j] / 10 <= 0)
                Console.Write($" {array2D[i, j]} "); //ровные строки и столбцы 

            else Console.Write($"{array2D[i, j]} ");
        }

        System.Console.WriteLine();
    }
}

int SumRow(int[,] array2D, int i)
{
    int sumRow = array2D[i, 0];
    for (int j = 1; j < array2D.GetLength(1); j++)
    {
        sumRow = sumRow + array2D[i, j];
    }
    return sumRow;
}



int rows = InputNumberWithMessage("Введите количество строк создаваемого массива ");
int columns = InputNumberWithMessage("Введите количество столбцов создаваемого массива ");

int[,] array2D = new int[rows, columns];

FillArray2D(array2D);
System.Console.WriteLine();
PrintArray2D(array2D);

int minSumRow = 0;
int sum = SumRow(array2D, 0);
for (int i = 1; i < array2D.GetLength(0); i++)
{
    int temp = SumRow(array2D, i);
    if (sum > temp)
    {
        sum = temp;
        minSumRow = i;
    }
}

Console.WriteLine($"Cтрокa с наименьшей суммой элементов: {minSumRow + 1}");

