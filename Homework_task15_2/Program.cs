int insertNum = int.Parse(Console.ReadLine()??"0");
var daysOfWeek = new Dictionary<int,string>
{
    { 1, "Понедельник,рабочий"},
    { 2, "Вторник,рабочий"},
    { 3, "Среда,рабочий"},
    { 4, "Четверг,рабочий"},
    { 5, "Пятница,рабочий"},
    { 6, "Суббота,выходной"},
    { 7, "Воскресенье,выходной"},
};
if ((insertNum>0) && (insertNum<8))
{
    Console.WriteLine (daysOfWeek[insertNum]);
}

else
{
    Console.WriteLine("Введенное число не соответствует дню  недели. Пожалуйста,выберите другое число от 1 до 7.");
}
