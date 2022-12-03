// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите число a = ");
int a = int.Parse(Console.ReadLine()!);

if(a > 99)
{
    string b = a.ToString().Substring(0, 3);
    a = Convert.ToInt32(b);
    Console.WriteLine("Третья цифра заданного числа: " + a % 10);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}