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