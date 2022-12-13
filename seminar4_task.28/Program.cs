using System.Numerics;

long ReadData(string line)
{
    Console.Write(line); //Выводим сообщение
    //Считываем число
    long insertNum = long.Parse(Console.ReadLine()??"0");
    //Возвращаем значение
    return insertNum;
}
BigInteger Factorial(long insertNum)
{
    BigInteger product = 1;
    for(long i =2; i<=insertNum;i++)
    {
            product *= i;

    }
    return product;
;
}

// метод вывода результата
void PrintResult (string line)
{
    Console.WriteLine(line);

}

long insertNum = ReadData("Введите любое число:");
BigInteger result = Factorial(insertNum);
PrintResult("Факториал числа " + insertNum + " равeн: " + result);