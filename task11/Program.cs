﻿// напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа 

 Console.Clear();
 int num = Math.Abs(new Random().Next(100,1000 ));
  int first= num/100;
  int second= num%10; 
 Console.WriteLine($"{num}-> {first*10+second}");
// исполнение методом!!

 int MinusMidlle(int num)
{
int firstDigit = num / 100;
int secontDigit = num % 10;
int result = firstDigit * 10 + secontDigit;
return result;
}
Console.Write("Введите целое трехзначное число- ");
int number =Math.Abs(int.Parse(Console. ReadLine()));

Console.WriteLine(number);

int res = MinusMidlle(number);

Console.WriteLine($"{number}->{res}");