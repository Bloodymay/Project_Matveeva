int num1 = int.Parse(Console.ReadLine()??"0");
int num2 = int.Parse(Console.ReadLine()??"0");

if ((num1 == num2*num2) || (num2 == num1*num1))
{
    Console.WriteLine(" Является квадратом числа ");
}
else
{
    Console.WriteLine("Не является квадратом числа " );
}


