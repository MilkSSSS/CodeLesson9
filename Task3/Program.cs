// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int sum = Akkermann(Prompt("Input M:"), Prompt("Input N:"));
Console.WriteLine($"The result is {sum}");
Console.ReadLine();

int Akkermann (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return Akkermann(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return Akkermann(numberM - 1, Akkermann(numberM, numberN - 1));
    return Akkermann(numberM, numberN);
}