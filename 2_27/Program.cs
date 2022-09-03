﻿// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetSum(num));
int GetSum(int number)
{
    int sum = 0;
    while(number>0)
    {
        sum+=number%10;
        number/=10;
    }
    return sum;
}