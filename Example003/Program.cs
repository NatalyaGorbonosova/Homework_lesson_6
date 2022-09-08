// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. 
// Определить , является ли это сторонами треугольника. Если да, то вывести всю информацию по нему - площадь, периметр, 
// значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.
bool IfTriangle(double a, double  b, double  c)
{
    if(a < b + c && b < a + c && c < a + b) return true;
    else return false;
}
void AllAboutTriangle(double a, double b, double c)
{
    double P = a + b + c;
    double p = P/2;
    double S = Math.Round(Math.Sqrt(P*(p - a)*(p - b)*(p - c)));
    double cosA = (a*a + b*b - c*c)/(2*a*b);
    double cosB = (a*a - b*b + c*c)/(2*a*c);
    double cosC = (-a*a + b*b + c*c)/(2*b*c);
    double cornerA =Math.Round(Math.Acos(cosA)*180/3.14, 0) ;
    double cornerB = Math.Round(Math.Acos(cosB)*180/3.14, 0) ;
    double cornerC = Math.Round(Math.Acos(cosC)*180/3.14, 0) ;
    Console.WriteLine($"P = {P}, S = {S}");
    Console.WriteLine($"Углы треугольника равны: {cornerA}, {cornerB}, {cornerC}");
}
void WhatTriangle (double a, double b, double c)
{
    string vid = "";
    if(a == b || a == c || b == c)
    {
        if(a == b && b == c)  vid = "равносторонний";
        else vid = "равнобедренный ";
    }
    if(a*a == b*b + c*c || b*b == a*a + c*c || c*c == a*a + b*b) vid = vid + "прямоугольный ";
    if(vid == "") Console.WriteLine("Треугольник произвольный");
    else Console.WriteLine("Треугольник "+ vid);
}
try
{
    Console.WriteLine("Введите стороны треугольника:");
    double sideA = Convert.ToDouble(Console.ReadLine());
    double sideB = Convert.ToDouble(Console.ReadLine());
    double sideC = Convert.ToDouble(Console.ReadLine());
    if(IfTriangle(sideA, sideB, sideC))
    {
        AllAboutTriangle(sideA, sideB, sideC);
        WhatTriangle(sideA, sideB, sideC);
    }
    else Console.WriteLine("Это не треугольник!");
}
catch
{
    Console.WriteLine("Вводите только числа");
}