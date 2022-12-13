//Алгоритмический способ решения
//Запрос данных у пользователя
// int ReadData(string line)
// {
//     Console.Write(line); //Выводим сообщение
//     //Считываем число
//     int insertNum = int.Parse(Console.ReadLine()??"0");
//     //Возвращаем значение
//     return insertNum;
// }
// // метод вывода результата
// void PrintResult (string line)
// {
//     Console.WriteLine(line);

// }

 int Sum(int numA)
{
    int sum = 0;
    for(int i =1; i<=numA;i++)
    {
        sum += i;

    }
    return sum;
}
// int numA = ReadData("Введите любое число:");
// int result = Sum(numA);
// PrintResult("Сумма чисел от 1 до " + numA + " равна: " + result);

//
int ReadData(string line)
{
    Console.Write(line); //Выводим сообщение
    //Считываем число
    int insertNum = int.Parse(Console.ReadLine()??"0");
    //Возвращаем значение
    return insertNum;
}
// метод вывода результата
void PrintResult (string line)
{
    Console.WriteLine(line);

}
int VariantSumGauss(int numA)
{
    int sum = 0;
    sum = ((numA + 1)*numA)/2;
    return sum;
}
 int numA = ReadData("Введите любое число:"); 

 DateTime d1 = DateTime.Now;

int result1 = VariantSumGauss(numA);

Console.WriteLine(DateTime.Now-d1);
 
 
DateTime d2 = DateTime.Now;

int result2 = Sum(numA);

Console.WriteLine(DateTime.Now-d2);
PrintResult("Сумма чисел от 1 до " + numA + " (по формуле Гаусса) равна: " + result1);
PrintResult("Сумма чисел от 1 до " + numA + " равна: " + result2);
