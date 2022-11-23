/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.*/
Random rnd = new Random();
int Number = rnd.Next();
string str = Convert.ToString(Number);
System.Console.WriteLine();
System.Console.WriteLine($"Заданное число: {Number}");
if (Number >= 100)
    System.Console.WriteLine($"Третьей цифрой этого числа является {str[2]}.");
else
    System.Console.WriteLine($"У числа {Number} нет третьей цифры");