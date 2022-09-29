﻿// No29 Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

Console.Clear();

int ReadData(string msg)
{
    System.Console.Write(msg);
    int number = int.Parse(System.Console.ReadLine()??"0");
    return number;
}

int[] Fill1DArray(int len, int lowBord, int highBord)
{
    int[]array= new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i]= new Random().Next (lowBord,highBord+1);
    }
    return array;
}

void Print1DArray(int []array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        System.Console.Write(array[i]+", ");
    }
    System.Console.WriteLine(array[array.Length-1]+"]");
}

int arrayLen=ReadData("Введите длину массива ");
int lowBord=ReadData("Введите нижнюю границу массива: ");
int highBord=ReadData("Введите верхнюю границу массива: ");
int[]array= Fill1DArray(arrayLen,lowBord,highBord);
Print1DArray(array);
