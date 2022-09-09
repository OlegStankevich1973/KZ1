Console.Clear();
string[] EnteringNumbers()//keyboard input method
{
    Console.WriteLine("Введите требуемое положительное количество чисел M");

    int size = int.Parse(Console.ReadLine());
    string[] buferArr = new string[size];//создаем буферный массив вводимых чисел
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите {0}-й элемент", i + 1);
        buferArr[i] = Console.ReadLine();
    }
    return buferArr;
}

string[] CountNumbers(string[] inputArray)//method to count numbers in a string

{
    int k = 0;
    int newSize = 0;
    string[] outputArray = new string[inputArray.Length];
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            newSize++;
            Array.Resize(ref outputArray, newSize);
            outputArray[k] = inputArray[i];
            k++;
        }
    }
    return outputArray;
}
void PrintArray(string[] inputArray)//method print
{
    Console.Write("[ ");

    for (int i = 0; i < inputArray.Length - 1; i++)
    {
        Console.Write("\"" + inputArray[i] + "\"" + " , ");

    }
    Console.Write("\"" + inputArray[inputArray.Length - 1] + "\"" + " ]");
}
string[] arrayInputNumbers = EnteringNumbers();
string[] sortedArray = CountNumbers(arrayInputNumbers);

Console.WriteLine();
PrintArray(arrayInputNumbers);
Console.Write("  =>  ");
PrintArray(sortedArray);
