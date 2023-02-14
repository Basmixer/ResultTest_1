string[] CreateArray(int size)  // М Е Т О Д  создает массив путем ввода с клавиатуры
{
    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} element: ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

void ShowArray(string[] array)  // М Е Т О Д отображает сгенерированный массив
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " | ");
    Console.WriteLine();
}

string[] ModifiedArray(string[] array) // М Е Т О Д создает новый массив "обесценивая" элементы несоответствующие задаче
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) array[i] = array[i];
        else array[i] = "";
    }
    return array;
}

void ShowResult(string[] array) // М Е Т О Д отображающий элементы массива, соответствующие условию задачи
{
    Console.WriteLine("array elements, corresponding to the task condition (from the new resultArray): ");
    for (int i = 0; i < array.Length; i++)
        if (array[i] != "") Console.WriteLine("array[{0}] = {1}", i, array[i]);
}

Console.Write("Input a length of STRING array: ");
int length = Convert.ToInt32(Console.ReadLine());
   
string[] newArray = CreateArray(length);
    Console.WriteLine();
        ShowArray(newArray);
    
string[] resultArray = ModifiedArray(newArray);
ShowArray(resultArray);
    Console.WriteLine();
        ShowResult(resultArray);
            Console.WriteLine();
