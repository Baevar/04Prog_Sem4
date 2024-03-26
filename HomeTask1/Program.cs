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

bool CheckingEvenNumber(int number)
{
    int sum = 0;
    int numLen = CheckingLengthNum(number);
    for (int i = 0; i < numLen; i++)
    {
        sum += number % 10;
        number /= 10;
    }
    if (sum % 2 == 0) return true;
    return false;
}

int CheckingLengthNum(int number)               // функция проверки количества цифр в числе
{
    int count = 1;
    while (number > 9 || number < -9)
    {
        number /= 10;
        count++;
    }
    return count;
}


Console.WriteLine("Введите q или условное число для выхода из цикла:");
string inputString;
bool stat = false;
while (true)
{
    inputString = Console.ReadLine();
    stat = CheckingForTheLetter(inputString, "q");
    if (stat == true) break;
    stat = CheckingForTheNumber(inputString);
    if (stat == true) break;

}