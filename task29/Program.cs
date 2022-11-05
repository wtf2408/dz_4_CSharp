Console.Clear();
Console.Write("Введите длинну массива: ");
bool isParsed = int.TryParse(Console.ReadLine(), out int arrayLength);
Console.Clear();


int[] UserArray (int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите элемент{i+1}: ");
        bool x = int.TryParse(Console.ReadLine(), out int n);
        arr[i] = n;
    }
    return arr;
}

void PrintArray(int [] arr)
{
    Console.Write("[ ");
    for (int j = 0; j < arr.Length; j++)
    {
        Console.Write($"{arr[j]} ");
    }
    Console.Write("]");
}

if (!isParsed)
{
    Console.WriteLine("!error!");
    return;
}

int[] array = UserArray (arrayLength);
PrintArray(array);

