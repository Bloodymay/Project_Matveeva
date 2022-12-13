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
int [] GenArray(int num)
{
    Random rnd = new Random();
    int[] array = new int [num];
    for (int i = 0;i<array.Length-1;i++)
    {
        array [i] = rnd.Next(0,2);

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
    Console.Write(array[array.Length-1] + " ]");
}
int arrayLenght = ReadData("Введите длину массива ");


int[] array = GenArray(arrayLenght);


PrintData("Cгенерированный массив:  ", array); 