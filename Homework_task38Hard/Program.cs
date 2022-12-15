int min = int.MaxValue;
int max = int.MinValue;
int len = ReadData("Задайте длину массива: ");
int[] array = GenArray(len, 0, 12);
Print1DArr(array);
DateTime d1 = DateTime.Now;

int[] sortedArray = BubbleSortMethod(len, array);
Print1DArr(sortedArray);
int sortedDiff = SortedArrayDiff(len);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;

int diff = MinMax(min, max);
Console.WriteLine(DateTime.Now - d2);
PrintData("Разница между маскимальным и минимальным числом массива(пузырек) равна: " + sortedDiff);
PrintData("Разница между маскимальным и минимальным числом массива равна: " + diff);

int SortedArrayDiff(int len)//Находим раницу между первым и последним элементом массива
{
    int result = sortedArray[array.Length - 1] - sortedArray[0];
    return result;
}



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
        array[i] = new Random().Next(0, 12);
    }
    return array;
}
//Печатаем массив
int[] BubbleSortMethod(int len, int[] array)//Сортируем массив от меньших элеменов к большим
{
    int[] sortedArray = array;
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    return sortedArray;
}


void Print1DArr(int[] array)//Печатаем массив
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

int MinMax(int min, int max) // Выясняем минимальное и максимальное значение,выводит разницу.
{
    int diff = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return diff = max - min;
}

void PrintData(string msg) // Выводим результат в консоль

{
    Console.WriteLine(msg);
}