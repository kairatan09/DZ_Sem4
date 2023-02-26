// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Pow(int A, int B)
{
  int res = 1;
  if (B >= 0)
  {
    for (int i = 1; i <= B; i++)
    {
      res = res * A;
    }
    Console.WriteLine();
    Console.WriteLine($"{A} в степени {B} равно - {res}");
  }
  else
    Console.WriteLine("Введенный степень не натуральный!");
}



try
{
  Console.Write("Введите натуральное число:\t");
  int A = Convert.ToInt32(Console.ReadLine());
  Console.Write("\nВведите натуральную степень числа:\t");
  int B = Convert.ToInt32(Console.ReadLine());

  Pow(A, B);
}
catch
{
  Console.WriteLine("Были введены некорректные данные!");
}