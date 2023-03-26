string PromptText(string message)
{
    Console.Write(message);
    string result = Console.ReadLine();
    return result;
}

int PromptNumber(string message)
{
    Console.Write(message);
    int result = Int32.Parse(Console.ReadLine()!);
    return result;
}

string [] CreateArray()
{
    int size = PromptNumber("Какого размера массив вы хотите создать: ");
    string [] array = new string [size];
    return array;
}

string [] FillArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = PromptText($"Введите значение {i+1} элемента: ");        
    }
    return array;
}








string [] arr = CreateArray();
FillArray(arr);

foreach (var item in arr)
{
    System.Console.WriteLine(item);
}