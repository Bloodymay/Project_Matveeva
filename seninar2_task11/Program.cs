System.Random numberSint = new System.Random();
int number = numberSint.Next(100,1000);
Console.WriteLine(number);
int a  = number/100;
int b = number%10;
int result = a*10+b;
Console.WriteLine(result);
