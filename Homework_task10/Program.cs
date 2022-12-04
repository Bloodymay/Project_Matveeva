int insertNum = int.Parse(Console.ReadLine()??"0");

if ((insertNum<1000)&&(insertNum>99))
{
 int result = (insertNum/10)%10;
 Console.WriteLine(result);
}
else 
{
    Console.WriteLine(" Вы ввели не трехзначное число. Введите другое. ");
}