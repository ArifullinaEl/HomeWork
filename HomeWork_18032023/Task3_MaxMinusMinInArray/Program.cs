/* Задайте массив вещественных чисел. Найдите разницу 
между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

//Вещественных это double???

int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void FillArrayRandom(double[] array)
{
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1,100);
    }
}


void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


double CalculateDifferenceBetwennMaxAndMin(double[] array)
{
    double diff = 0;
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i]; 
    
        diff = max - min;
    }
    return diff;
        
}

int length = InputNumberWithMessage("Введите размер массива ");
double [] nunbers = new double [length];
FillArrayRandom(nunbers);
PrintArray(nunbers);
double result = CalculateDifferenceBetwennMaxAndMin(nunbers);
System.Console.WriteLine();
System.Console.WriteLine($"Разница между max и min:  {result}");






