// особенное приветствие
Console.Write("Ввдите Ваше имя ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    System.Console.WriteLine("Ура! Это Маша!");
}
else
{
    System.Console.Write("Привет! ");
    System.Console.WriteLine(username);
}