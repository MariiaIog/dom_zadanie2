/* Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.*/

int dayNumber = new int();
Console.WriteLine("Введите число от 1 до 7, соответствующее дню недели");
dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine("Вы ввели неверное число. Попробуйте еще раз.");
}
else if (dayNumber > 5)
{
    Console.WriteLine("Этот день - выходной!");
}
else
{
    Console.WriteLine("Это рабочий день недели.");
}
