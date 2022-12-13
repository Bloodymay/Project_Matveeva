int ReadData(string msg)
{
    Console.WriteLine(msg); //Выводим сообщение
    //Считываем число
    
    //Возвращаем значение
    return int.Parse(Console.ReadLine()??"0");
}
void PrintData (string res, int[] array)
{
    Console.WriteLine(res);
    PrintArray(array);
}
int [] GenArray(int insertNum1,int insertNum2,int arrayLenght)
{
    Random rnd = new Random();
    int[] array = new int [arrayLenght];
    
    for (int i = 0;i<array.Length-1;i++)
    {
        array [i] = rnd.Next(insertNum1,insertNum2);

    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i =0; i<array.Length-1;i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write( array [array.Length-1] + " ]");
}
int insertNum1 = ReadData("Введите первый параметр массива ");
int insertNum2 = ReadData("Введите второй параметр массива ");
int arrayLenght = ReadData("Введите длину массива ");

int[] array = GenArray(insertNum1,insertNum2,arrayLenght);
PrintData("Cгенерированный массив:  ", array); 