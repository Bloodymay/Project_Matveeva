Console.Write("Введите числа через запятую:");
int [] array = Array.ConvertAll(Console.ReadLine().Split( "," ),int.Parse);
int count = 0;
for (int i=0;i<array.Length;i++)
{
    if (array[i]>0)
    {
        count ++;
    }
}
Console.WriteLine($"Количество чисел выше 0 = {count} ");
