// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.


System.Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели");
int inputNumber = Convert.ToInt32(System.Console.ReadLine());

if (inputNumber >= 1 && inputNumber <= 5) 
{
    System.Console.WriteLine("Этот день рабочий");
}

else
{
    if (inputNumber == 6 || inputNumber == 7)
    {
        System.Console.WriteLine("Этот день выходной");
    }

    else
    {
        System.Console.WriteLine("Будьте внимательнее, только от 1 до 7");
    }

}

