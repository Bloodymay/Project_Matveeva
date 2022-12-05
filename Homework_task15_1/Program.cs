int insertNum = int.Parse(Console.ReadLine()??"0");
string [] daysOfWeek = new string [6];
daysOfWeek[0]=  "Рабочий"; daysOfWeek[1]="Рабочий"; daysOfWeek[2]= "Рабочий";
daysOfWeek[3]=  "Рабочий"; daysOfWeek[4]= "Рабочий"; daysOfWeek[5]= "Выходной"; daysOfWeek[6] = "Выходной";
if ((insertNum>0)&&(insertNum<8))
{
Console.WriteLine(daysOfWeek[insertNum - 1]);
}
else
{
    Console.WriteLine("Введенное число не соответствует дню  недели. Пожалуйста,выберите другое число от 1 до 7.");
}