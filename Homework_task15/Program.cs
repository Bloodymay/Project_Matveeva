int insertNum = int.Parse(Console.ReadLine()??"0");
if ((insertNum>0)&&(insertNum<8))
{
    if (insertNum>5)
    Console.WriteLine("Выходной");
    else
    {
        Console.WriteLine("Рабочий");
    }
}
else
{
    Console.WriteLine("Введенное число не является днем недели! Пожалуйста, введите число от 1 до 7.");
}
