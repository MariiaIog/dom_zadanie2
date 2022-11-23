/*Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.*/

int number = new Random().Next(100, 999);
int secondNumber = number / 10 % 10;
System.Console.Write($"Рандомное число {number}. ");
System.Console.WriteLine($"Вторая цифра этого числа является {secondNumber}.");