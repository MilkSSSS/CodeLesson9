// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int n = Prompt("Input M:");
int m = Prompt("Input N:");
int sum = SumNumbers(m, n);
Console.WriteLine($"Sum numbers from {m} till {n} = {sum}.");
Console.ReadLine();


int SumNumbers(int firstNum, int secondNum)
{
    if (firstNum == secondNum) return firstNum;
    return firstNum + SumNumbers(firstNum + 1, secondNum);
}