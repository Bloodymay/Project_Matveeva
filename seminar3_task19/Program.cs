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
void PrintData( string message)
{
    Console.WriteLine(message);
}



int insertNum = ReadData("Введите пятизначное число");
if ((insertNum>9999)&&(insertNum<100000))

{
    bool result = Palindrome(insertNum);
    if (result==true)
    {
        
        PrintData(insertNum + " - Число является палиндромом");
    }
    
    else
    {
         PrintData(insertNum + " - Число не является палиндромом");
    }     



}
else
{
    Console.WriteLine(insertNum + " - не является пятизначным числом. Введите другое");
}