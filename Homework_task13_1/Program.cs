int insertNum = int.Parse(Console.ReadLine()??"0");

while (insertNum>999)
{
    insertNum = insertNum/10;
}
    int result = insertNum%10;
    Console.WriteLine(result);