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

string[] CreateArray()
{
    int size = PromptNumber("Какого размера массив вы хотите создать: ");
    string[] array = new string[size];
    return array;
}

string[] FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = PromptText($"Введите значение {i + 1} элемента: ");
    }
    return array;
}

int CountElementsShorterThanFour(string[] array)
{
    int count = 0;
    foreach (string el in array)
    {
        if (el.Length < 4)
        {
            count++;
        }
    }
    return count;
}

string[] RewriteArray(string[] array)
{
    string[] massif = new string[CountElementsShorterThanFour(array)];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            massif[j] = array[i];
            j++;
        }
    }
    return massif;
}

void PrintArray(string[] array)
{
    Console.Write("Ваш массив: ");
    foreach (var item in array)
    {
        System.Console.Write($"{item}\t");
    }
}

void TaskSolution()
{
    string[] arr = CreateArray();
    FillArray(arr);
    PrintArray(arr);

    System.Console.WriteLine();

    string[] newArray = RewriteArray(arr);
    System.Console.WriteLine();
    PrintArray(newArray);
}

TaskSolution();