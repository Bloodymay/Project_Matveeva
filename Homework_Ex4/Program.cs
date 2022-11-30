string? firstNumber = Console.ReadLine();
string? secondNumber = Console.ReadLine();
string? thirdNumber = Console.ReadLine();
if (firstNumber != null && secondNumber != null && thirdNumber != null);
{
    int num1 = int.Parse(firstNumber);
    int num2 = int.Parse(secondNumber);
    int num3 = int.Parse(thirdNumber);
   
    int max = num1;
    if (num2>max) max = num2;
    
       
    if (num3>max) max = num3;

    Console.WriteLine(max);
    
} 

