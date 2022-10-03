//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

// Console.WriteLine("Введите длинну массива: ");
// string n = Console.ReadLine();
// int n1 = Convert.ToInt32(n);

// double[] Array = new double[n1];
// double max = 0;
// double min = 0;
// for (int i = 0; i < Array.Length; i++)
// {
//     Array[i] = new Random().NextDouble() * n1;
// }
// if (Array[i] > max)
//     {
//         max = Array[i];
//     }
//     if (Array[i] < min)
//     {
//         min = Array[i];
//     }
Console.WriteLine("Введите длинну массива: ");

string n = Console.ReadLine();
int n1 = Convert.ToInt32(n);
double [] NewArray(int size)
{
    double[] Array = new double[size];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().NextDouble();
    }
    return Array;
}
double[] Array = NewArray(n1);
double max =Array[0];
double min =Array[0];
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] > max)
     {
         max = Array[i];
     }
}
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] < min)
     {
         min = Array[i];
     }

}

Console.WriteLine(String.Join(",  ", Array));
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine();
Console.WriteLine(max - min);


