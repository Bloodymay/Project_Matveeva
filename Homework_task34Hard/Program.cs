//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int ReadData(string line)//Просим пользователя задать длину массива.
{
    Console.Write(line); //Выводим сообщение
    //Считываем число
    int insertNum = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return insertNum;
}
int[] GenArray(int len, int minValue, int maxValue)// Генерируем массив из случайных чисел с тремя параметрами: Длина,минимальное значение и максимальное значение
{
    Random rnd = new Random();
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue,maxValue);
    }
    return array;
}
int[] BubbleSortMethod(int len , int[] array)//Сортируем массив от меньших элеменов к большим
{
    int [] sortedArray =  array;
    int  temp = 0 ;
    for(int  i = 0;i<array.Length;i++)
    {
     for(int  j = i+1;j<array.Length;j++)
     {
        if (array[i]>array[j])
        {
            temp = array[i];
            array[i]=array[j];
            array[j]=temp;
        }
     }   
    }
    return sortedArray;
}

//Печатаем массив
void Print1DArr(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]+" ]");
}
int CountOfEven(int[] array) // Производим подсчет количества четных чисел
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
void PrintData(string msg, int count) // Выводим результат в консоль

{
    Console.WriteLine(msg + count);
}



int len = ReadData("Задайте длину массива:");
int minValue = ReadData("Задайте минимальное значение массива:");
int maxValue = ReadData("Задайте максимальное значение массива:");
int[] array = GenArray(len, minValue, maxValue);
Print1DArr(array);
int[] sortedArray=BubbleSortMethod(len,array);
Print1DArr(sortedArray);
int count = CountOfEven(array);
PrintData("Количество четных чисел в сгенерированном массиве равно: ", count);
