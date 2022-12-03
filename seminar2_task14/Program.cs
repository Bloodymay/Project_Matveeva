int num = int.Parse(Console.ReadLine()??"0");
int res1 = num%7;
int res2 = num%21;
if ((res1==0)&&(res2==0))
{
    Console.WriteLine(num +" Делится на 7 и 21 без остатка.");
}
else
{
    Console.WriteLine("Число " + num + " Не кратно числам 7 и 21." );
}