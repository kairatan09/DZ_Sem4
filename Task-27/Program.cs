// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Welcome(string message)
{
  Console.Write(message);
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}

void Sum(int number)
{
  int temp = number;
  if (number > 0)
  {
    int res = 0;
    for (int i = 0; number > 0; i++)
    {
      res += number % 10;
      number /= 10;
    }
    Console.WriteLine($"\nСумма цифр числа {temp} равно: \t{res}");
  }
  else
    Console.WriteLine("Введенное число не натуральное!");
}

try
{
  int number = Welcome("Введите натуральное число:\t");
  Sum(number);
}
catch
{
  Console.WriteLine("Были введены некорректные данные");
}