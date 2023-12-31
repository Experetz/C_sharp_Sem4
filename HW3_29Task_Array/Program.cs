﻿/* Напишите программу, которая задаёт массив из 8 элементов
и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

// Метод заполнения массива
void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0, 50);
        Console.Write(array[index] + "   ");
        index++;
    }
}

//---------------------------------------------------
int[] array = new int[8];
FillArray(array);