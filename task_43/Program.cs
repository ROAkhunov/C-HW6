// Задача 43. Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями y = k1 * 
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются 
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 
// 9 -> (-0,5; -0,5)


void GetMeet(double b1, double k1, double b2, double k2)
{
 double y=Math.Round((-b1/k1*k2+b2)/(1-k2/k1),1);
   double x = Math.Round((y-b1)/k1,1);
  Console.WriteLine($"Точка перечечения: ({x};{y})");
}

Console.WriteLine("Введите b1:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1:");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2:");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2:");
int k2 = Convert.ToInt32(Console.ReadLine());
GetMeet(b1,k1,b2,k2);