int a = int.Parse(Console.ReadLine()??"0");
int b = int.Parse(Console.ReadLine()??"0");
int result = b%a;
if (result==0)
{
    Console.WriteLine("Второе число делится на первое без остатка");
  
}
else 
{
    Console.WriteLine("Второе число не кратно первому. Остаток от деления = "  + result);
}