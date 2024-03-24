// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.

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


void PrintArray(int[] array)                        // Вывод массива данных на печать
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

int CountEvenNumber(int[] array)                   // Проверяем сколько четных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}



Console.WriteLine("Введите размер массива");

int size = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(size, 100, 1000);

PrintArray(arr);

int count = CountEvenNumber(arr);

Console.WriteLine($"\n Количество четных чисел в массиве={count}");

