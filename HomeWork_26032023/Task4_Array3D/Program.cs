/*  ...Сформируйте трёхмерный массив из неповторяющихся двузначных
 чисел. Напишите программу, которая будет построчно выводить массив,
 добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */


int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void FillArray3D(int[,,] array3D)
{
    Random rnd = new Random();

    for (int a = 0; a < array3D.GetLength(0); a++)
    {
        for (int b = 0; b < array3D.GetLength(1); b++)
        {
            for (int c = 0; c < array3D.GetLength(2); c++)
            {

                array3D[a, b, c] = rnd.Next(10, 100);



            }

        }
    }
}

void PrintArray3D(int[,,] array3D)
{
    for (int a = 0; a < array3D.GetLength(0); a++)
    {
        for (int b = 0; b < array3D.GetLength(1); b++)
        {
            for (int c = 0; c < array3D.GetLength(2); c++)
            {
                System.Console.Write($"{array3D[a, b, c]} ({a} {b} {c}) {" "}");
            }

            System.Console.WriteLine();
        }
    }
}
int a = InputNumberWithMessage("Введите a ");
int b = InputNumberWithMessage("Введите b ");
int c = InputNumberWithMessage("Введите c ");

int[,,] array3D = new int[a, b, c];

FillArray3D(array3D);
System.Console.WriteLine();
PrintArray3D(array3D);
