// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 326791123 -> 6

System.Console.WriteLine("Введите любое целое число");

int N = Convert.ToInt32(Console.ReadLine());

while (N > 1000)
{
    N = N / 10;
}

if (N < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}

else {
    System.Console.WriteLine(N%10);
}