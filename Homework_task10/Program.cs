int insertNum = int.Parse(Console.ReadLine()??"0");//Парсим введенное число

if ((insertNum<1000)&&(insertNum>99))//Проверяем,является ли введенное число трехзначным. Если нет выводится сообщение об ошибке
{
 int result = (insertNum/10)%10;//Если да делим его на 10 и в остатке от деления получаем второе число
 Console.WriteLine(result);
}
else 
{
    Console.WriteLine(" Вы ввели не трехзначное число. Введите другое. ");
}