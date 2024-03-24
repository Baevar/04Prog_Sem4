// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)

using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

int[] CreateArray(int size, int min, int max)       // создание массива случайных чисел
{
    int[] array = new int[size];

    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}


void PrintArray(int[] array)
{
   Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

int[] ReverseArray (int[] array)
{
    int akk;
    for(int i = 0; i<array.Length/2; i++)
    {
        akk = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = akk;
    }
    return array;
}



Console.WriteLine("Введите размер массива");

int size = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(size, 1, 100);

PrintArray(arr);

arr = ReverseArray(arr); 
Console.WriteLine();
PrintArray(arr);