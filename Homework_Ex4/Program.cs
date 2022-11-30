string? firstNumber = Console.ReadLine();
string? secondNumber = Console.ReadLine();
string? thirdNumber = Console.ReadLine();
if (firstNumber != null && secondNumber != null && thirdNumber != null);
{
    int num1 = int.Parse(firstNumber);
    int num2 = int.Parse(secondNumber);
    int num3 = int.Parse(thirdNumber);
   
    
    if (num1>num2)
    
    {
        Console.WriteLine(num1);
    }
       
    if (num2 > num3)

    {
        Console.WriteLine(num2);
    }
    else
    {
        Console.WriteLine(num3);
    }
} 
