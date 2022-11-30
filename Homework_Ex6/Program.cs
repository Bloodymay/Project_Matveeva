string? insertNumber = Console.ReadLine();
if (insertNumber != null);
{
    int num = int.Parse(insertNumber);
    int a = num%2;
    if (a==0)
    {
        Console.WriteLine("Четное");
    } 

    else
    {
        Console.WriteLine("Нечетное");
    }
}