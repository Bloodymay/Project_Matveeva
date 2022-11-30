string? insertNumber = Console.ReadLine();
if(insertNumber!= null)
{
int num = int.Parse(insertNumber);
int a = 2;
int outputNum = 0;
while (a <= num);
{

    outputNum = outputNum + a;
    a = a+2;

}
Console.WriteLine(outputNum);
}   


