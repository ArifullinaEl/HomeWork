/* Задайте две матрицы. Напишите программу, которая 
будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */


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
//System.Console.WriteLine("Количество строк массива1 = Количество столбцов массива2");
//System.Console.WriteLine("Количество столбцов массива1 = Количество строк массива2");
int r = InputNumberWithMessage("Введите количество строк массива 1: ");
int c1 = InputNumberWithMessage("Введите количество столбцов массива 1: ");
int cc = InputNumberWithMessage("Введите количество столбцов массива 2: ");

int[,] array2Dfirst = new int[r, c1];
int[,] array2Dsecond = new int[c1, cc];

FillArray2D(array2Dfirst);
System.Console.WriteLine();
System.Console.WriteLine("Массив 1 ");
PrintArray2D(array2Dfirst);
System.Console.WriteLine();

FillArray2D(array2Dsecond);
System.Console.WriteLine();
System.Console.WriteLine("Массив 2 ");
PrintArray2D(array2Dsecond);

int[,] array2Dresult = new int[c1, cc];


for (int i = 0; i < array2Dresult.GetLength(0); i++)
{
    for (int j = 0; j < array2Dresult.GetLength(1); j++)
    {
        int m = 0;
        for (int k = 0; k < array2Dfirst.GetLength(1); k++)
        {
            m = m + array2Dfirst[i, k] * array2Dsecond[k, j];
        }
        array2Dresult[i, j] = m;
    }
}
System.Console.WriteLine();
System.Console.WriteLine("Итоговый Массив  ");
PrintArray2D(array2Dresult);