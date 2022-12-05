int insertNum = int.Parse(Console.ReadLine()??"0");// Парсим введенное число

while (insertNum>999)
{
    insertNum = insertNum/10;//Делим его на 10 пока оно не примет вид трехзначного числа
}
    int result = insertNum%10;//Получаем остаток от деления на 10
    Console.WriteLine(result);//результат выводим  в консоль.