﻿string? insertNumber = Console.ReadLine();//Пользователь вводит число
if (insertNumber! = null);//Проводим проверку на наличие данных
{
    int num = int.Parse(insertNumber);//Парсим введенное число
    int a = num%2; // Проверяем есть ли остаток от деления на 2
    if (a==0)
    {
        Console.WriteLine("Четное");//Если остаток от деления на 2 равен нулю, то выводим в консоль сообщение : Четное
    } 

    else
    {
        Console.WriteLine("Нечетное");//Если остаток от деления на 2 равен 1, то выводим в консоль сообщение : Нечетное
    }
}