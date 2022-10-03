string[] array = new string[4] {"hello", "2", "world", ":-)"};

void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            Console.Write($"\"{array[i]}\",");
        }
    }
    Console.Write("]");
}

PrintArray(array);
