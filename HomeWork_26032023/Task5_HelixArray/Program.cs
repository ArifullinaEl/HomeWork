/*  Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */


int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} "); //ровные строки и столбцы 

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int n = InputNumberWithMessage("Введите размер массива: ");

int[,] array2D = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= array2D.GetLength(0) * array2D.GetLength(1))
{
    array2D[i, j] = temp;
    temp = temp + 1;

    if (i <= j + 1 && i + j < array2D.GetLength(1) - 1)
        j = j + 1;
    else

    if (i < j && i + j >= array2D.GetLength(0) - 1)
        i = i + 1;
    else

    if (i >= j && i + j > array2D.GetLength(1) - 1)
        j = j - 1;
    else
        i = i - 1;
}

PrintArray(array2D);

