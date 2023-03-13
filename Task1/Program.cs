// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в
// промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

Console.WriteLine("The result is " + FindAllEllements(Prompt("Введите число N:")));
Console.ReadLine();

string FindAllEllements(int number)
{
    if (number == 1) return number + " ";
    return number + " " + FindAllEllements(number - 1);
}