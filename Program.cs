string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Input array[{i}]: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void ShowArray(string[] array)
{
    string z = String.Empty;
    for (int i = 0; i < array.Length; i++)
        z += $"{array[i]}, ";
    z = z.TrimEnd(new char[] { ',', ' ' });
    Console.Write($"[{z}] -> ");
}

void ShowArrayThirdSymbol(string[] array)
{
    string z = String.Empty;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
            z += $"{array[i]}, ";
    z = z.TrimEnd(new char[] { ',', ' ' });
    Console.WriteLine($"[{z}]");
}

Console.Write("Input array size: ");
int a = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(a);
ShowArray(myArray);
ShowArrayThirdSymbol(myArray);

