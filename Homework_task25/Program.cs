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
long Exponentiation(int insertNum1, int insertNum2)
{
    int result=1;
    for (int i = 1; i<=insertNum2;i++)
    {
        result = insertNum1*result;
    }
return result;
}
int insertNum1 = ReadData("Введите любое число:"); 
int insertNum2 = ReadData("Введите степень,в которую вы хотите возвести введенное ранее число: "); 
long res = Exponentiation(insertNum1,insertNum2);
PrintResult(insertNum1 + " в степени " + insertNum2 + " равно " + res);
