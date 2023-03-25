/* Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой 
строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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
int rows = InputNumberWithMessage("Введите количество строк создаваемого массива ");
int columns = InputNumberWithMessage("Введите количество столбцов создаваемого массива ");

int[,] array2D = new int[rows, columns];

FillArray2D(array2D);
System.Console.WriteLine();
PrintArray2D(array2D);



for (int i = 0; i < array2D.GetLength(0); i++)
{

    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        for (int k = 0; k < array2D.GetLength(1) - 1; k++)
        {
            if (array2D[i, k] < array2D[i, k + 1])
            {
                int temp = array2D[i, k + 1];
                array2D[i, k + 1] = array2D[i, k];
                array2D[i, k] = temp;
            }

        }

    }
}
System.Console.WriteLine();
PrintArray2D(array2D);


