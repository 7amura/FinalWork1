// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

string[] myArray = {"hello", "2", "world", ":-)", "98754", "643", "-5"};
string[] FirstArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] NewArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            NewArray[j] = array[i];
            j++;
        }
    }
    return NewArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length -1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}
PrintArray(FirstArray(myArray));