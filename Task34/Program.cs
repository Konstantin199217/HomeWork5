//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int[] NewArray(int size)
{
    int[] Array = new int[size];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(100, 999);
    }
    return Array;
}


int[] Array = NewArray(ReadData("Введите длинну массива: "));

Console.WriteLine(String.Join(",", Array));
Console.WriteLine();
int number = 0;
for (int i = 0; i <= Array.Length -1; i++)
{
    if (Array[i] % 2 == 0) number++;
}
Console.WriteLine(number);




