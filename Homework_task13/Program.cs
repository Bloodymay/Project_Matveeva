int insertNum = int.Parse(Console.ReadLine()??"0");
if (insertNum>99)
{
    char[] array = insertNum.ToString().ToCharArray();
    Console.WriteLine(array[2]);
}
else 
{
    Console.WriteLine("Третьей цифры не существует");
}