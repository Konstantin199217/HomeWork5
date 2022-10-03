//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

int[] NewArray(int size)
{
    int[] Array = new int[size];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(0, 20);
    }
    return Array;
}
