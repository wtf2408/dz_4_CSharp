//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Method (int a , int b)
{
    int c = 1;
    for (int i = 1; i < b; i++)
    {
        c = a;
        c=c*a;
    }
    return c;
}

Console.Clear();
Console.WriteLine("Введите число A");
bool isParsed = int.TryParse(Console.ReadLine(), out int numberA);

Console.WriteLine("Введите число B");
bool isParsed1 = int.TryParse(Console.ReadLine(), out int numberB);

if (!isParsed || !isParsed1)
{
    Console.WriteLine("error");
    return;
}

int result = Method(numberA, numberB);
Console.WriteLine($"ответ: {result}");
