/*
Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше или равна 3м символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется использовать коллекциями,
лучше обойтись исключительно массивами.
*/

using System;

string[] arrayOfStrings = new string[]
{
    "Hello",
    "Russia",
    "-123",
    "Up",
    "man",
    "Всем привет",
    "кто",
    "куда",
    "тут",
    "*&^%^",
    "%$%"
};
PringStringArray(arrayOfStrings);
int count = 0;

for (int i = 0; i < arrayOfStrings.GetLength(0); i++)
{
    if (compareStringsForOurTask(arrayOfStrings[i]))         // сверим с условием задачи
    {
        count++;                                             // считаем сколько нам понадобится ячеек для строк в новом массиве
    }
}
string[] resultArray = new string[count];                    // создадим результирующий массив
Console.WriteLine(); 
count = 0;                                                   // обнуляем счетчик
for (int i = 0; i < arrayOfStrings.GetLength(0); i++)
{
    if (compareStringsForOurTask(arrayOfStrings[i]))         // сверим с условием задачи
    {
        resultArray[count] = arrayOfStrings[i];              // если строка меньше чем четыре символа, запишем в результирующий массив
        count++;                                             // на данном этапе count индекс результирующего массива
    }
}
PringStringArray(resultArray);

                                                             // просто метод вывода массива на экран(в терминал,консоль...)
void PringStringArray(string[] symbols)
{
    for (int i = 0; i < symbols.GetLength(0); i++)
    {
        Console.Write(symbols[i] + " ");
    }
}
                                                             // метод сравнения строки по нашему заданию
Boolean compareStringsForOurTask(string text)
{ 
    if (text.Length < 4)
    {
        return true;
    }
    return false;
}