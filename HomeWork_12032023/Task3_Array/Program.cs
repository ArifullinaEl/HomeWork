/* Напишите программу, которая задаёт массив из 
8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRndom(int[] array)
{
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0,100);
    }
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}



int length = InputNumberWithMessage("Введите размер массива: ");
int [] nunbers = new int [length];
FillArrayRndom(nunbers);
PrintArray(nunbers);


/* int [] array = new int [length];
Random rnd = new Random();

for (int i =0; i < length; i++)
   {
    array[i] = rnd.Next(-100,100);
   }

for (int i =0; i < length; i++)
   {
    Console.Write(array[i] + " ");
   }*/