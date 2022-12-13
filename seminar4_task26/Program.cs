//Console.Write("Введите число: ");

//string? NumberStr = Console.ReadLine();
//int Number = int.Parse(NumberStr??"0");

//Console.WriteLine((int)(1+Math.Log10(Number)));
// int VariantSimple(int num)
// {
//     int count = 0;
//     for (int i=0; i<num; i++)
//     {
//         num=num/10;
//         count++;
//     }
//     return count;
// }

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }
int ReadData(string line)
{
    Console.Write(line); //Выводим сообщение
    //Считываем число
    int num = int.Parse(Console.ReadLine()??"0");
    //Возвращаем значение
    return num;
}
void PrintData(string res)
{
    Console.WriteLine(res);
}

int VariantLog(int num)
{
    int count = (int)Math.Log10(num)+1;
    return count;
}
int num = ReadData("Введите число А:");
int length = VariantLog(num);
PrintData("Количество цифр в числе равно: " + length);


