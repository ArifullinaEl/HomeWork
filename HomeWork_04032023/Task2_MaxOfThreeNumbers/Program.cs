// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

int inputNumberA = Convert.ToInt32(Console.ReadLine());
int inputNumberB = Convert.ToInt32(Console.ReadLine());
int inputNumberC = Convert.ToInt32(Console.ReadLine());

int max = inputNumberA;

if (inputNumberB > max) max = inputNumberB;
if (inputNumberC > max) max = inputNumberC;
    

Console.WriteLine(max);
