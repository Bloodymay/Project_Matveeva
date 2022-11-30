string? firstNumber = Console.ReadLine();
string? secondNumber = Console.ReadLine();
 if (firstNumber != null && secondNumber != null);

 {
    int num1 = int.Parse(firstNumber);
    int num2 = int.Parse(secondNumber);
    if (num1 > num2)
    {
        Console.WriteLine("num1 Большее число");
        Console.WriteLine("num2 Меньшее число");

    }
    else 
    {
        Console.WriteLine("num1 Меньшее число");
        Console.WriteLine("num2 Большее число");
    }
 }