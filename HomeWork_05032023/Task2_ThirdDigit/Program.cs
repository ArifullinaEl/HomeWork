// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

System.Console.WriteLine("Введите число");
int inputNumber = Convert.ToInt32(System.Console.ReadLine());
string inputNumberText = Convert.ToString(inputNumber);

if (inputNumberText.Length>2) 
{
    System.Console.WriteLine(inputNumberText[2]);
}

else
{
    System.Console.WriteLine("третьей цифры нет");
}

