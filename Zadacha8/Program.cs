// Напишите программу, которая принимает на вход число (N) и на выходе показывет все четные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 6, 8 

Console.WriteLine("Введите натуральное число ");
int x= Convert.ToInt32 (Console.ReadLine());
int count = 1;
while (count<x)
{
    if (count%2==0)
    {
        Console.WriteLine(count+",");
        count++;
    }
    else count++;
}