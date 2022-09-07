// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void PointCross(double k1, double b1, double k2, double b2)
{
    double x = Math.Round((b2 - b1)/(k1 - k2), 2);
    double y = Math.Round(k1*x + b1, 2);
    Console.WriteLine($"прямые у = {k1}x + {b1}, y = {k2}x + {b2} пересекаются в точке ({x}; {y})");
}
try
{
    Console.WriteLine("Введите коэффициент k1: ");
    double firstK = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент b1: ");
    double firstB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент k2: ");
    double secondK = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент k2: ");
    double secondB = Convert.ToInt32(Console.ReadLine());
    if(firstK != secondK) PointCross(firstK, firstB, secondK, secondB);
    else Console.WriteLine("Прямые параллельны, точек пересечения нет");
}
catch
{
    Console.WriteLine("Введите числа");
}