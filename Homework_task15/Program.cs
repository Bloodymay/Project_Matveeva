int insertNum = int.Parse(Console.ReadLine()??"0"); //Парсим введенное число
if ((insertNum>0)&&(insertNum<8)) // проверяем число на соответствие дню недели
{
    if (insertNum>5) 
    Console.WriteLine("Выходной"); //Если введенное число меньше 5 -выводим в консоль результат рабочий. Если больше-выходной
    else
    {
        Console.WriteLine("Рабочий");
    }
}
else
{
    Console.WriteLine("Введенное число не является днем недели! Пожалуйста, введите число от 1 до 7.");
}
