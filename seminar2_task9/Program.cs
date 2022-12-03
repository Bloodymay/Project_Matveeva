System.Random numberSint = new System.Random();
int number = numberSint.Next(10,100);
//Console.WriteLine(number);
//int firstNum = number/10;
//int secondNum = number%10;
//if (firstNum>secondNum)
{
    //Console.WriteLine(firstNum);


}
//else
{
    //Console.WriteLine(secondNum);
}

//Вариант2 

char [] array = numberSint.Next(10,100).ToString().ToCharArray();
Console.WriteLine(array);
int firstNum = ((int)array[0])-48;
int secondNum = ((int)array[1])-48;
int resNum = firstNum>secondNum?resNum=firstNum:resNum=secondNum;
 Console.WriteLine(resNum);