//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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
        Array[i] = new Random().Next(0, 20);
    }
    return Array;
}
int[] Array = NewArray(ReadData("Введите длинну массива: "));

Console.WriteLine(String.Join(",", Array));
Console.WriteLine();
int number = 0;
for (int i = 0; i < Array.Length ; i+=2)
{ 
    number += Array[i];
}
Console.WriteLine("Сумма элементов, стоящих на нечетных позициях: " + number);

