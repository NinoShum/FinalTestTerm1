/*Задача: 
Написать программу, которая из имеющегося массива 
строк формирует массив из строк, длина которых меньше либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры,
 либо задать на старте выполнения алгоритма. 
 При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами. */

Console.Write("Количество элементов в массиве ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = new string[size];
CreateArray(array);
Console.WriteLine();
PrintArray(array);
string[] arrayResult = new string[size];
FindResult(array, arrayResult);
Console.WriteLine();
PrintArray(arrayResult);

string[] CreateArray(string[] array)
{
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите элемент: ");
        string type = Convert.ToString(Console.ReadLine());
        array[i] = type;
    }
    return array;
}



string[] FindResult(string[] array1, string[] array2)
{

    int simbol = 3;
    int result = 0;

    for (int j = 0; j < size; j++)
    {
        if (array1[j].Length <= simbol)
        {
            array2[result] = array1[j];
            result++;
        }
    }
    return array2;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

