string? insertNumber = Console.ReadLine();
if(insertNumber!= null);
{
int num = int.Parse(insertNumber);
int a = 2;
string outputNum  = string.Empty;
while (a <= num)
{
  
   
     outputNum = outputNum + a;
     a = a+2;
}
   
Console.WriteLine( outputNum );
}

   


