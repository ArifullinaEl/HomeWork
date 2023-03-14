/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

//на нечетных позициях с точки зрения позиции пользователя
//или с точки зрения счетчика массива?

//здесь сделано с точки зрния пользователя, т.е.
//i = 0  - 1й элемент массива для пользователя.
//иначе, начало цикла i = 1 



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
        array[i] = rnd.Next(-99,100);
    }
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


int SumNumbersForUnevenCounts(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i=i+2)  //i = 0  - 1й элемент массива для пользователя
    {
            sum = sum +array[i];
        
    }
    return sum;
}

int length = InputNumberWithMessage("Введите размер массива ");
int [] nunbers = new int [length];
FillArrayRandom(nunbers);
PrintArray(nunbers);
int result = SumNumbersForUnevenCounts(nunbers);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма элемнтов, стоящих на нечетных позициях  {result}");
