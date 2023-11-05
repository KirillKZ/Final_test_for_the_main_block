// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


//---------------------------------------------ТЕЛО------------------------------------------------ 

// создаем переменную для хранения размера первого массива, инициализируем ее значением полученным от пользователя
int arrSize = ReadData("Введите размер массива: ");
//переменная для хранения длины строки, уканной в условии задачи
int maxLength = 3;
//переменная для сохранения количества строк, соответствующих критерию, заданному в условии задачи
int lessOrEquel3Chars = 0;
//создаем и инициализируем переменную для хранения начального массива
string[] arr = CreateArray(arrSize);
//создаем и инициализируем переменную для хранения итогового массива
string[] arrResult = WordsLessThen3(lessOrEquel3Chars, arr);
//выводим на экран содержимое начального и итогового массивов
Console.Write($"{ArrayToString(arr)} → {ArrayToString(arrResult)}");



//-----------------------------------------------МЕТОДЫ-------------------------------------------

//метод считывает данные из консоли и преобразует в формат integer
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//метод считывает данные из консоли 
string ReadDataString(string msg)
{
    Console.Write(msg);
    return Console.ReadLine() ?? "0";
}
//метод для преобразования массива в строку для дальнейшего вывода на экран
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
//метод для создания массива указанного размера и заполнения его значениями, введенными пользователем, а так же для подсчета 
//количества строк соответствующих критерию - длина меньше, либо равна 3 символам.
string[] CreateArray(int arrLength)
{
    string[] arr = new string[arrLength];
    string str = "";

    for (int i = 0; i < arr.Length; i++)
    {
        str = ReadDataString("Введите строку: ");
        arr[i] = str;
        if (str.Length <= maxLength)
        {
            lessOrEquel3Chars++;
        }
    }
    return arr;
}
//метод для создания и заполнения итогового массива строками, соответствующими критерию, заданному в условии задачи
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

