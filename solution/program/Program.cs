// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


//тело программы 
int arrSize = ReadData("Введите размер массива: ");
int maxLength = 3;
int lessOrEquel3Chars = 0;
string[] arr = CreateArray(arrSize);
string[] arrResult = WordsLessThen3(lessOrEquel3Chars, arr);
Console.Write($"{ArrayToString(arr)} → {ArrayToString(arrResult)}");



//методы
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

string ReadDataString(string msg)
{
    Console.Write(msg);
    return Console.ReadLine() ?? "0";
}

string ArrayToString(string[] arr)
{
    if (arr.Length > 0)
    {
        string result = String.Empty;
        result += "[";
        for (int i = 0; i < arr.Length - 1; i++)
        {
            result += "“" + arr[i] + "”, ";
        }
        return result + "“" + arr[arr.Length - 1] + "”]";
    }
    else
    {
        return "[]";
    }
}

string[] CreateArray(int arrLength)
{
    string[] arr = new string[arrLength];
    string str = "";

    for (int i = 0; i < arr.Length; i++)
    {
        str = ReadDataString("Введите последовательность знаков: ");
        arr[i] = str;
        if (str.Length <= maxLength)
        {
            lessOrEquel3Chars++;
        }
    }
    return arr;
}

string[] WordsLessThen3(int arrLength, string[] arr)
{
    string[] arrResultult = new string[arrLength];
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {

        if (arr[i].Length <= maxLength)
        {
            arrResultult[count++] = arr[i];
        }
    }
    return arrResultult;

}

