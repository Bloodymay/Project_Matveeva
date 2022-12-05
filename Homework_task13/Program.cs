int insertNum = int.Parse(Console.ReadLine()??"0");//Парсим введенное число
if (insertNum>99)//Если число больше 99 - преобразовываем его в массив и выводим в консоль число с индексом 2. Если нет - выводим,что третьей цифры не существует
{
    char[] array = insertNum.ToString().ToCharArray();
    Console.WriteLine(array[2]);
}
else 
{
    Console.WriteLine("Третьей цифры не существует");
}