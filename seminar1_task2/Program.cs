string? inputLine = Console.ReadLine();
if (inputLine!=null)
{

    string[] dayOfWeek = new string[7];
    dayOfWeek[0] = "Понедельник"; 
    dayOfWeek[1] = "Вторник"; 
    dayOfWeek[2] = "Среда"; 
    dayOfWeek[3] = "Четверг"; 
    dayOfWeek[4] = "Пятница"; 
    dayOfWeek[5] = "Суббота"; 
    dayOfWeek[6] = "Воскресенье"; 

    int inputNum = int.Parse(inputLine);

    string outDayOfWeek = dayOfWeek[inputNum - 1];
    
    Console.WriteLine(outDayOfWeek);

}