﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Welcome(string message)
{
  Console.Write(message);
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}

int[] NewArray(int Length, int Min, int Max)
{
  int[] array = new int[Length];
  Random RND = new Random();
  for (int i =0; i < Length; i++)
    array[i] = RND.Next(Min, Max + 1);
  return array;
}


void PrintArray(int[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length - 1; i++)
      Console.Write($"{array[i]}, ");
  Console.Write($"{array[array.Length - 1]}]");
}

try
{
int Length = Welcome("Введите длину массива:\t");
int Min = Welcome("Введите начальное значение случайных чисел для заполнения массива:\t");
int Max = Welcome("Введите конечное значение случайных чисел для заполнения массива:\t");

int[] array = NewArray(Length, Min, Max);
PrintArray(array);
}

catch
{
  Console.WriteLine("Были введены некорректные данные");
}