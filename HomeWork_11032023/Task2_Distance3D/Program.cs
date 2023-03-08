/* Напишите программу, которая принимает на вход координаты
двух точек и находит расстояние между ними в 3D пространстве
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */


double InputNumberWithMessage (string message)
{
    System.Console.Write(message);
    double value = Convert.ToDouble(Console.ReadLine()); // можно убрать value
    return value;                                        // return Convert.ToDouble(Console.ReadLine());
}


double CountDistanceAxis(double a, double b)
{
    double distance = (double) Math.Pow(b-a,2);
    return distance;
}

double x1 = InputNumberWithMessage("Введите координаты точки A по оси x: ");
double y1 = InputNumberWithMessage("Введите координаты точки A по оси y: ");
double z1 = InputNumberWithMessage("Введите координаты точки A по оси z: ");

double x2 = InputNumberWithMessage("Введите координаты точки B по оси x: ");
double y2 = InputNumberWithMessage("Введите координаты точки B по оси y: ");
double z2 = InputNumberWithMessage("Введите координаты точки B по оси z: ");


double dis1 = CountDistanceAxis(x1, x2);
double dis2 = CountDistanceAxis(y1, y2);
double dis3 = CountDistanceAxis(z1, z2);

// double dis1 = Math.Pow(x2-x1,2);
// double dis2 = Math.Pow(y2-y1,2);
// double dis3 = Math.Pow(z2-z1,2);

double result = Math.Round(Math.Sqrt(dis1+dis2+dis3),2);
System.Console.WriteLine("Расстояние между двумя точками " + result);