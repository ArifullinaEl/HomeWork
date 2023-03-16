/* Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3  ошибка!? почему3? */


int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void FillArray(int[] array)
{
   
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputNumberWithMessage($"Введите {i+1} число: ");
    }
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
            if (array[i] > 0)
            count = count + 1;
        
    }
    return count;
}

int length = InputNumberWithMessage("Введите количество чисел: ");
int [] nunbers = new int [length];


FillArray(nunbers);
PrintArray(nunbers);

int result = CountPositiveNumbers(nunbers);

System.Console.WriteLine();
System.Console.WriteLine($"Количество положительных чисел: {result}");


