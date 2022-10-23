// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double k1, b1;
double k2, b2;

Console.WriteLine("Укажите  переменные k и b для двух прямыx заданых уравнением:");
Console.WriteLine("y = k * x + b");
Console.Write("k1 = ");
k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1 = ");
b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2 = ");
k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
b2 = Convert.ToDouble(Console.ReadLine());

Coordinate(k1, b1, k2, b2);


// Метод, который находит координаты точки пересечения
void Coordinate (double numk1, double numb1, double numk2, double numb2)
{
 double resultx = 0;
 double resulty = 0;

     if (numk1 != numk2)
 {
   resultx = (numb2 - numb1) / (numk1 - numk2);
   resulty = numk2 * resultx + numb2;
 }
    else if (numb1 == numb2) Console.WriteLine("Прямые совпадают");
    else Console.WriteLine("Прямые параллельны");

Console.WriteLine($"Координаты точки пересечения: x = {resultx}, y = {resulty}");
}