// // int num = ReadData("Введите число:");
// Console.WriteLine("Введите число: ");
// int[]arrValues = Array.ConvertAll<string,int> (Console.ReadLine().Split(','),elem=>
// {
//     return System.Convert.ToInt32(elem);});
// foreach(int intValue in arrValues)
// Console.WriteLine(intValue);
// // {   try
// //     catch(Exception e)
// //     {
// //         Console.WriteLine("Вы ввели неверное число");
// //     }
    
// //  }
// // int num = 0;



int[] genarray = ReadData("Введите числa через запятую: " );
int result = CountPositiveNum(genarray);
PrintData ("Количество чисел больше нуля равно:  ", result) ;


int[] ReadData(string line)//Просим пользователя ввести ряд чисел
{
    Console.Write(line); //Выводим сообщение
    //Считываем число
    int [] genarray = Array.ConvertAll(Console.ReadLine().Split( "," ),int.Parse);
    return genarray;
    //Возвращаем значение
    
}
void PrintData(string msg, int result) // Выводим результат в консоль

{
    Console.WriteLine(msg + result);
}

int CountPositiveNum( int [] array)//Считаем количество чискл выше нуля

{
    int result=0;
    for(int i = 0; i < array.Length-1;i++)
    {
        if (i >0+1) result++;
        
    }
    

  
    return result;
}
