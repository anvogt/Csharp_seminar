// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите цифру дня недели");
int N = Convert.ToInt32(Console.ReadLine());

if (0 < N && N < 6)

{
    System.Console.WriteLine("Это не выходной день :(");
}

else if (5 < N && N < 8)

{
    System.Console.WriteLine("Это выходной день!");
}

else

{
    System.Console.WriteLine("Такого дня недели не существует");
}