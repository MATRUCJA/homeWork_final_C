// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

using System.ComponentModel.DataAnnotations;
using System.Globalization;

string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент массива {i} ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] NewArray(string[] array)
{
    int i = 0;
    int sizeNewArr = 0;
    while (i < array.Length)
    {
        if (array[i].Length <= 3)
        {
            sizeNewArr++;
        }
        i++;
    }
    
    string[] newArr = new string[sizeNewArr];
    int j = 0;
    for (i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArr[j] = array[i];
            j++;
        }
    }
    return newArr;

}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = CreateArray(size);
Console.WriteLine($"Заданный массив:[ {string.Join(", ", array)} ]");
string[] newArray = NewArray(array);

if (newArray.Length>0)
Console.WriteLine($"Итоговый массив:[ {string.Join(", ", newArray)} ]");
else Console.WriteLine("\nЭлементы, длина сток которых меньше, либо равна 3 символам, отсутсвуют!\n");



