// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.


bool CheckingForTheLetter(string str, string check) // проверка, совпадают ли входные данные и проверяемой строкой
{
    if (str == check)
    {
        return true;
    }

    return false;
}

bool CheckingForTheNumber(string str)           // Проверяю, является ли введенная строка числом
{
    int number;

    bool evenSuDdigit = false;

    if (int.TryParse(str, out number))
    {
        evenSuDdigit = CheckingEvenNumber(number);
    }

    return evenSuDdigit;
}

bool CheckingEvenNumber(int number)             // Проверяю, делится ли число на 2 без остатка
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }

    if (sum % 2 == 0) return true;

    return false;
}

Console.WriteLine("Введите q или условное число для выхода из цикла:");

//string inputString;

while (true)
{
<<<<<<< HEAD
    inputString = Console.ReadLine();
    stat = CheckingForTheLetter(inputString, "q");
    if (stat == true) break;
    stat = CheckingForTheNumber(inputString);
    if (stat == true) break;

=======
    string inputString = Console.ReadLine();

    if (CheckingForTheLetter(inputString, "q") == true) break;

    
    if (CheckingForTheNumber(inputString) == true) break;
    
>>>>>>> 58d1dafc406c929d604c79928c1a5634092193a5
}