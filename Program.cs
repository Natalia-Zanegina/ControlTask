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

string Print(string[] array)
{
    int length = array.Length;
    string output = String.Empty;
    for (int i = 0; i < length; i++)
    {
        output += ($"\"{array[i]}\" ");
    }
    return output;
}

int size = 4; // зададим произвольный размер массива для проверки работы программы.
              // В случае необходимости можно добавить пользовательский ввод
string[] myArray = CreateArray(size);
Fill(myArray);
string input = Print(myArray);
Console.WriteLine($"input: {input}");

int count = CountOfElements(myArray);
string[] resultArray = ArrayOfElementsUpTo3Char(myArray, count);
string output = Print(resultArray);
Console.WriteLine($"output: {output}");