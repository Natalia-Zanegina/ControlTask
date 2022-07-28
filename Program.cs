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

string[] ArrayOfElementsUpTo3Char(string[] array, int count)
{
    string[] newArray = new string[count];
    int index = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        int length = array[i].Length;
        if (length <= 3)
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;
}