int ReadData(string message)
{
    Console.WriteLine(message);
   
    return int.Parse(Console.ReadLine()??"0");
}

bool Palindrome(int insertNum)
{
bool result = false;
result = (insertNum/10000 == insertNum%10)&&((insertNum/1000)%10)==((insertNum/10)%10);
return result;
}
void PrintData( string message, bool result)
{
    Console.WriteLine(message + result);
}



int insertNum = ReadData("Введите пятизначное число");
if ((insertNum>9999)&&(insertNum<100000))

{
    if 
    {
        bool result = Palindrome(insertNum);
        PrintData("Число является палиндромом", result);
    }
    
    else
    {
         PrintData("Число не является палиндромом", result);
    }     



}
else
{
    Console.WriteLine(insertNum + " - не является пятизначным числом. Введите другое");
}