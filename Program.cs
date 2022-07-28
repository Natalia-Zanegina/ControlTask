string[] CreateArray(int size)
{
    return new string[size];
}

void Fill(string[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
            Console.Write($"Input {i + 1} string: ");
            array[i] = Console.ReadLine();
    }
}

int CountOfElements(string[] array)
{
    int len = array.Length;
    int count = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}