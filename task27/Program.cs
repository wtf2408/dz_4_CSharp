/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
452 -> 11
82 -> 10
9012 -> 12
*/
int Length (int n)
{
    int count = 0;
    while (n>0)
    {
        n = n/10;
        count ++;
    }
    return count;
}

int [] ConvertToArray (int n, int length)
{
    int[] arr = new int[length];
    for (int i = arr.Length-1; i >=0; i--)
    {
        arr[i]=n%10;
        n = n/10;
    }
    return arr;
}

int SumOfNumbers (int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return sum;

}

Console.Clear(); 
Console.WriteLine("Введите число:");        
bool isParsed = int.TryParse(Console.ReadLine(), out int number);
if (!isParsed)
{
    Console.WriteLine("error");        
}

int numberLength = Length(number); 
int [] array = ConvertToArray (number, numberLength);
int result = SumOfNumbers (array);
Console.WriteLine($"сумма цифр в числе: {result}");