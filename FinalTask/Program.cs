// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


Console.WriteLine($"Введите количество значений: ");
int countArrayValue = int.Parse(Console.ReadLine());

string[] startArray = new string[countArrayValue];

string[] FillArray(string[] array)
{
    for (int i = 0; i < countArrayValue; i++)
    {
        Console.WriteLine($"Введите {i} значение:");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] SortArray(string[] array)
{
    int countNecessaryValue = 0;
    string arrayValue = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        arrayValue = array[i];
        if (arrayValue.Length <= 3) countNecessaryValue++;
    }

    string[] endArray = new string[countNecessaryValue];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        arrayValue = array[i];
        if (arrayValue.Length <= 3)
        {
            endArray[index] = array[i];
            index++;
        }
    }
    return endArray;
}

void PrintArray(string[] array)
{
    if (array.Length == 0) Console.WriteLine($"Массив не имеет значений!");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" [{array[i]}]");
    }
}

FillArray(startArray);

string[] endArray = SortArray(startArray);

Console.WriteLine($"Первоначальный массив:");
PrintArray(startArray);

Console.WriteLine($"Массив значений с длинной (<) либо = (3) символа:");
PrintArray(endArray);