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
int SumOfNumbers(int insertNum)
{
    int result = 0;
    while( insertNum>0)
    {
        result+=insertNum%10;
        insertNum = insertNum/10;

        
    }
    return result;
}
int insertNum = ReadData("Введите любое число ");
int result = SumOfNumbers(insertNum);
PrintResult("Сумма цифр числа "+ insertNum +" равна " + result);
