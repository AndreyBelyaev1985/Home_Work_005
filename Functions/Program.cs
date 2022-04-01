﻿int Promt(string message)      // Считывает любой тип информации с консоли 
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}
double[] RandArray(int lenght)   // Рандомный массив
{
    double[] answer = new double[lenght];
    for (int i = 0; i < lenght; i++)
    {
        Random rnd = new Random();                      // вариант без отрицательных: answer[i] = new Random().NextDouble()*100; (*100 - дает возможность генерировать значение от 0 до 100)
        answer[i] = rnd.NextDouble();      // диапазон от -100 до 100
    }                                                           
    return answer;
}

void PrintArray(double[] collect)   // Выводит массив в консоль
{
    Console.Write("[");
    for (int i = 0; i < collect.Length - 1; i++)
    {
        Console.Write(collect[i] + ", ");

    }
    Console.Write(collect[collect.Length - 1] + "]");
}
double FindMax(double[] arr)        // Поиск максимального
{
    double maxElem = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (maxElem < arr[i]) maxElem = arr[i];
    }
    return maxElem;
}
double FindMin(double[] arr)        // Поиск минимального
{
    double minElem = arr[0];
    for (int j = 1; j < arr.Length; j++)
    {
        if (minElem > arr[j]) minElem = arr[j];
    }
    return minElem;
}

int N = Promt("Введите необходимую длину массива => ");
if (N == 0) Console.WriteLine("Массив не может быть длиной 0");
else
{
    double[] arr = RandArray(N);
    PrintArray(arr);
    Console.WriteLine();
    double max = FindMax(arr);
    double min = FindMin(arr);
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {max - min}");
}