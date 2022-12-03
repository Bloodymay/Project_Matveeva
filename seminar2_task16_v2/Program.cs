//Вариант 1
//int num1 = int.Parse(Console.ReadLine()??"0");
//int num2 = int.Parse(Console.ReadLine()??"0");
//bool result1 = (num1/num2==num2);
//bool result2 = (num2/num1==num1);
//if (result1) Console.WriteLine(num1 + " Является квадратом числа " + num2);
//if (result2) Console.WriteLine(num2 + " Является квадратом числа " + num1);
//if (!result1 && !result2) Console.WriteLine("Не является квадратом");

// Вариант2
void Test (int i , int j)
{
    bool res = (i/j == j);
    if (res==true) Console.WriteLine( "Число " + i +" является квадратом числа "+j);
    else  Console.WriteLine( "Число " + i +" не является квадратом числа "+j);

}
int num1 = int.Parse(Console.ReadLine()??"0");
int num2 = int.Parse(Console.ReadLine()??"0");

Test(num1,num2);
Test(num2,num1);
