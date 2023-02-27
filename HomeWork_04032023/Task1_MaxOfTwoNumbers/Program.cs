// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

int inputNumberA = Convert.ToInt32(Console.ReadLine());
int inputNumberB = Convert.ToInt32(Console.ReadLine());

if (inputNumberA > inputNumberB)
{
    string result = inputNumberA.ToString() + "больше чем" + inputNumberB.ToString();
    Console.WriteLine(result);
    
}

else
{
    Console.WriteLine($"{inputNumberB} больше чем {inputNumberA}");
    
}

